using ExtensionMethodPractice;

ExtensionMethods e = new ExtensionMethods();
//await e.BasicAsync();
//await e.TrackTaskAsync();
//await e.TaskTrackingAsync();
//await e.SequentialAsync();
await e.ConcurrentAsync();
//await e.Run();