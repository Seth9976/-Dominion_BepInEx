using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Foundation.Tests
{
	// Token: 0x02000009 RID: 9
	public class SA_TestSuiteConfig : ScriptableObject
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002FF8 File Offset: 0x000011F8
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestSuiteConfig()
		{
			Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestSuiteConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr);
			SA_TestSuiteConfig.NativeFieldInfoPtr_SkipInteractableTests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr, "SkipInteractableTests");
			SA_TestSuiteConfig.NativeFieldInfoPtr_PauseOnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr, "PauseOnError");
			SA_TestSuiteConfig.NativeFieldInfoPtr_TestGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr, "TestGroups");
			SA_TestSuiteConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr, 100663326);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003078 File Offset: 0x00001278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158734, XrefRangeEnd = 158741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestSuiteConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestSuiteConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestSuiteConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000219A File Offset: 0x0000039A
		public SA_TestSuiteConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000030B4 File Offset: 0x000012B4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021A3 File Offset: 0x000003A3
		public unsafe bool SkipInteractableTests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_SkipInteractableTests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_SkipInteractableTests)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000030DC File Offset: 0x000012DC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021BE File Offset: 0x000003BE
		public unsafe bool PauseOnError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_PauseOnError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_PauseOnError)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000021D9 File Offset: 0x000003D9
		public unsafe List<SA_TestGroupConfig> TestGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_TestGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_TestGroupConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestSuiteConfig.NativeFieldInfoPtr_TestGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_SkipInteractableTests;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_PauseOnError;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_TestGroups;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
