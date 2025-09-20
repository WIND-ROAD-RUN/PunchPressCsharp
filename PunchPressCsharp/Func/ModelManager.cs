using PunchPressCsharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PunchPressCsharp.Data.Config;

namespace PunchPressCsharp.Func
{
    internal class ModelManager
    {
        public Dictionary<string, string> listNameWithPath = new Dictionary<string, string>();
        public void ReadModelHomeDirectory()
        {
            listNameWithPath.Clear();
            var path = GlobalPath.ModelHome;
            if (System.IO.Directory.Exists(path))
            {
                var dirs = System.IO.Directory.GetDirectories(path);
                var folderList = new List<(string Name, DateTime Time)>();

                foreach (var dir in dirs)
                {
                    var folderName = System.IO.Path.GetFileName(dir);
                    DateTime time;
                    // 尝试解析为日期
                    if (DateTime.TryParse(folderName, out time))
                    {
                        folderList.Add((folderName, time));
                    }
                    // 如果是纯数字，按数字转为时间（如时间戳或年月日等，可根据实际需求调整）
                    else if (long.TryParse(folderName, out long num))
                    {
                        // 这里假设数字为yyyyMMdd格式
                        if (folderName.Length == 14)
                        {
                            if (DateTime.TryParseExact(folderName, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out time))
                            {
                                folderList.Add((folderName, time));
                            }
                        }
                    }
                }

                var sortedList = folderList
                    .OrderByDescending(f => f.Time)
                    .Select(f => (Name: f.Name, Path: System.IO.Path.Combine(path, f.Name)))
                    .ToList();


                foreach (var dir in sortedList)
                {
                    string modelConfigPath = dir.Path + @"\" + GlobalPath.ModelConfigName;

                    // 检查配置文件是否存在，并捕获异常
                    if (System.IO.File.Exists(modelConfigPath))
                    {
                        try
                        {
                            ModelConfig.LoadFromFile(modelConfigPath);
                            listNameWithPath.Add(dir.Name, dir.Path);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"配置文件格式错误或无法读取：{ex.Message}");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"配置文件不存在！:{dir.Path}");
                        return;
                    }
                }
            }

        }
    }
}
