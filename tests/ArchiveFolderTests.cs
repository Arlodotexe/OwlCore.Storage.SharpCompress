using SharpCompress.Archives;
using SharpCompress.Archives.GZip;
using SharpCompress.Archives.Tar;
using SharpCompress.Archives.Zip;

namespace OwlCore.Storage.SharpCompress.Tests;

[TestClass]
public class ZipFolderTests : CommonArchiveFolderTests
{
    protected override IWritableArchive CreateArchive() => ZipArchive.Create();
}

[TestClass]
public class GZipFolderTests : CommonArchiveFolderTests
{
    protected override IWritableArchive CreateArchive() => GZipArchive.Create();
}

[TestClass]
public class TarFolderTests : CommonArchiveFolderTests
{
    protected override IWritableArchive CreateArchive() => TarArchive.Create();
}