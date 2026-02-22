using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Profiling
{
	// Token: 0x02000254 RID: 596
	public class Sampler
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000125A5 File Offset: 0x000107A5
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000125B2 File Offset: 0x000107B2
		public Recorder GetRecorder()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000125BF File Offset: 0x000107BF
		public static Sampler Get(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00066F4C File Offset: 0x0006514C
		public static int GetNames(List<string> names)
		{
			return Sampler.GetSamplerNamesInternal(names);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00066F64 File Offset: 0x00065164
		public string GetSamplerName()
		{
			IntPtr intPtr = Sampler.GetSamplerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00066F88 File Offset: 0x00065188
		public string name
		{
			get
			{
				return this.isValid ? this.GetSamplerName() : null;
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000125CC File Offset: 0x000107CC
		public static IntPtr GetRecorderInternal(IntPtr ptr)
		{
			return Sampler.GetRecorderInternalDelegateField(ptr);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000125D9 File Offset: 0x000107D9
		public static IntPtr GetSamplerInternal(string name)
		{
			return Sampler.GetSamplerInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000125EB File Offset: 0x000107EB
		public static int GetSamplerNamesInternal(List<string> namesScriptingPtr)
		{
			return Sampler.GetSamplerNamesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(namesScriptingPtr));
		}

		// Token: 0x04001935 RID: 6453
		private static readonly Sampler.GetSamplerNameDelegate GetSamplerNameDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerNameDelegate>("UnityEngine.Profiling.Sampler::GetSamplerName");

		// Token: 0x04001936 RID: 6454
		private static readonly Sampler.GetRecorderInternalDelegate GetRecorderInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetRecorderInternalDelegate>("UnityEngine.Profiling.Sampler::GetRecorderInternal");

		// Token: 0x04001937 RID: 6455
		private static readonly Sampler.GetSamplerInternalDelegate GetSamplerInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerInternalDelegate>("UnityEngine.Profiling.Sampler::GetSamplerInternal");

		// Token: 0x04001938 RID: 6456
		private static readonly Sampler.GetSamplerNamesInternalDelegate GetSamplerNamesInternalDelegateField = IL2CPP.ResolveICall<Sampler.GetSamplerNamesInternalDelegate>("UnityEngine.Profiling.Sampler::GetSamplerNamesInternal");

		// Token: 0x02000C61 RID: 3169
		// (Invoke) Token: 0x060036AA RID: 13994
		private delegate IntPtr GetSamplerNameDelegate(IntPtr @this);

		// Token: 0x02000C62 RID: 3170
		// (Invoke) Token: 0x060036AC RID: 13996
		private delegate IntPtr GetRecorderInternalDelegate(IntPtr ptr);

		// Token: 0x02000C63 RID: 3171
		// (Invoke) Token: 0x060036AE RID: 13998
		private delegate IntPtr GetSamplerInternalDelegate(IntPtr name);

		// Token: 0x02000C64 RID: 3172
		// (Invoke) Token: 0x060036B0 RID: 14000
		private delegate int GetSamplerNamesInternalDelegate(IntPtr namesScriptingPtr);
	}
}
