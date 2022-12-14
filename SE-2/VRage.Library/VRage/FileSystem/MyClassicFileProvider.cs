using System;
using System.Collections.Generic;
using System.IO;

namespace VRage.FileSystem
{
	public class MyClassicFileProvider : IFileProvider
	{
		public Stream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			if (!File.Exists(path))
			{
				return null;
			}
			try
			{
				return File.Open(path, mode, access, share);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool DirectoryExists(string path)
		{
			return Directory.Exists(path);
		}

		public IEnumerable<string> GetFiles(string path, string filter, MySearchOption searchOption)
		{
			if (!Directory.Exists(path))
			{
				return null;
			}
			return Directory.GetFiles(path, filter, (SearchOption)searchOption);
		}

		public bool FileExists(string path)
		{
			return File.Exists(path);
		}
	}
}
