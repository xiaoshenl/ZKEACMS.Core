/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace ZKEACMS.PackageManger
{
    public interface IPackageInstaller
    {
        string PackageInstaller { get; }
        object Install(Package package);
        Type GetPackageType();
        Package Pack(object obj);
    }
}
