// object <=> IntPtr
// object to IntPtr (before calling WinApi):
List<string> list1 = new List<string>();
GCHandle handle1 = GCHandle.Alloc(list1);
IntPtr parameter = (IntPtr) handle1;
// call WinAPi and pass the parameter here

// back to object (in callback function):
GCHandle handle2 = (GCHandle) parameter;
List<string> list2 = (handle2.Target as List<string>);
list2.Add("hello world");