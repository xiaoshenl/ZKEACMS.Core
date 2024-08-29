/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.IO;

namespace ZKEACMS.PackageManger
{
    public interface IPackageInstallerProvider
    {
        IPackageInstaller CreateInstaller(string packageInstaller);
        IPackageInstaller CreateInstaller(Stream stream, out Package package);
    }
}
