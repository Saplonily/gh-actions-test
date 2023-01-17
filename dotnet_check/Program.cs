Directory.CreateDirectory("../test_dir");
File.WriteAllText("../test_dir/test.txt", $"test~~~~, {Environment.OSVersion}, {DateTime.Now}");
//test