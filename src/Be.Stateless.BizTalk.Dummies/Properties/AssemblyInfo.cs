#region Copyright & License

// Copyright © 2012 - 2020 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.BizTalk.XLANGs.BTXEngine;
using Microsoft.XLANGs.BaseTypes;

[assembly: AssemblyTitle("Be.Stateless.BizTalk.Dummies")]
[assembly: AssemblyDescription("BizTalk Factory's Dummy BizTalk Artifacts for BizTalk.Factory testing purposes.")]
[assembly: AssemblyCompany("be.stateless")]
[assembly: AssemblyCopyright("Copyright © 2012 - 2020 be.stateless. All rights reserved.")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyProduct("be.stateless BizTalk Factory (Debug Build)")]
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyProduct("be.stateless BizTalk Factory (Release Build)")]
#endif

[assembly: BizTalkAssembly(typeof(BTXService))]
[assembly: ComVisible(false)]

[assembly: AssemblyFileVersion("2.0.0.0")]
[assembly: AssemblyInformationalVersion("2.0.0.0")]
[assembly: AssemblyVersion("2.0.0.0")]
