using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchPressCsharp.HardwareCom
{
    public class ModbusTool
    {
        public ModbusClient modbusClient;

        public ModbusTool(string addr, int port)
        {
            // 创建一个 ModbusClient 对象，指定从站的 IP 地址和端口号（默认 Modbus TCP 端口为 502）
            modbusClient = new ModbusClient(addr, port);
            // 连接到 Modbus 从站
            try
            {
                modbusClient.Connect();
            }
            catch
            {

            }
        }
        public bool Connect()
        {
            try
            {
                modbusClient.Connect();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Connect(string addr, int port)
        {
            try
            {
                modbusClient = new ModbusClient(addr, port);
                modbusClient.Connect();
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// 将 float 值写入 PLC 的两个连续寄存器地址。
        /// </summary>
        /// <param name="modbusClient">已连接的 ModbusClient 实例。</param>
        /// <param name="startingAddress">起始寄存器地址。</param>
        /// <param name="value">要写入的 float 值。</param>
        /// <param name="isBigEndian">是否采用大端字节顺序。</param>
        public bool WriteFloatToPlc(int startingAddress, float value, bool isBigEndian)
        {
            if (!modbusClient.Connected)
                return false;
            try
            {
                ushort[] registers = SplitFloatToRegisters(value, isBigEndian);

                // 写入第一个寄存器
                modbusClient.WriteSingleRegister(startingAddress, registers[0]);
                // 写入第二个寄存器
                modbusClient.WriteSingleRegister(startingAddress + 1, registers[1]);
            }
            catch
            {
                return false;
            }

            return true;
        }
        public bool readbool(int adress)
        {

            bool[] state = modbusClient.ReadCoils(adress, 1);
            bool aa = state[0];
            return aa;
        }
        public bool WriteMultipleRegisters(int startingAddress, int[] values)
        {
            if (!modbusClient.Connected)
                return false;

            try
            {
                modbusClient.WriteMultipleRegisters(startingAddress, values);
            }
            catch
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// 将 float 拆分为两个 16 位寄存器值（ushort）。
        /// </summary>
        /// <param name="value">要拆分的 float 值。</param>
        /// <param name="isBigEndian">是否采用大端字节顺序。</param>
        /// <returns>包含两个 ushort 的数组。</returns>
        static ushort[] SplitFloatToRegisters(float value, bool isBigEndian)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian != !isBigEndian)
            {
                Array.Reverse(bytes);
            }

            ushort register1 = BitConverter.ToUInt16(bytes, 0); // 前两个字节
            ushort register2 = BitConverter.ToUInt16(bytes, 2); // 后两个字节

            return new ushort[] { register1, register2 };
        }
        /// <summary>
        /// 将两个 16 位寄存器值合并为一个 float。
        /// </summary>
        /// <param name="registers">包含两个 ushort 的数组。</param>
        /// <param name="isBigEndian">是否采用大端字节顺序。</param>
        /// <returns>合并后的 float 值。</returns>
        static float CombineRegistersToFloat(int[] registers, bool isBigEndian)
        {
            if (registers.Length < 2)
                throw new ArgumentException("寄存器数组必须至少包含两个值。");

            byte[] bytes = new byte[4];

            if (isBigEndian)
            {
                // 大端字节顺序：高位寄存器在前
                bytes[0] = (byte)(registers[0] >> 8);        // 寄存器1高位字节
                bytes[1] = (byte)(registers[0] & 0xFF);      // 寄存器1低位字节
                bytes[2] = (byte)(registers[1] >> 8);        // 寄存器2高位字节
                bytes[3] = (byte)(registers[1] & 0xFF);      // 寄存器2低位字节
            }
            else
            {
                // 小端字节顺序：低位寄存器在前
                bytes[0] = (byte)(registers[1] & 0xFF);      // 寄存器2低位字节
                bytes[1] = (byte)(registers[1] >> 8);        // 寄存器2高位字节
                bytes[2] = (byte)(registers[0] & 0xFF);      // 寄存器1低位字节
                bytes[3] = (byte)(registers[0] >> 8);        // 寄存器1高位字节
            }

            // 如果系统字节顺序与字节数组不一致，可能需要反转字节数组
            if (BitConverter.IsLittleEndian != isBigEndian)
            {
                Array.Reverse(bytes);
            }

            // 转换为 float
            float floatValue = BitConverter.ToSingle(bytes, 0);
            return floatValue;
        }
    }
}
