using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Foundation.Tests
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class SA_TestGroupConfig : global::Il2CppSystem.Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002A88 File Offset: 0x00000C88
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestGroupConfig()
		{
			Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestGroupConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr);
			SA_TestGroupConfig.NativeFieldInfoPtr_Tests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr, "Tests");
			SA_TestGroupConfig.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr, "Name");
			SA_TestGroupConfig.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr, "Enabled");
			SA_TestGroupConfig.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr, "Texture");
			SA_TestGroupConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002B1C File Offset: 0x00000D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158694, XrefRangeEnd = 158701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestGroupConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestGroupConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestGroupConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020D6 File Offset: 0x000002D6
		public SA_TestGroupConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002B58 File Offset: 0x00000D58
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020DF File Offset: 0x000002DF
		public unsafe List<SA_TestConfig> Tests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Tests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_TestConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Tests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002B88 File Offset: 0x00000D88
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000020FE File Offset: 0x000002FE
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000211D File Offset: 0x0000031D
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe Texture2D Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestGroupConfig.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_Tests;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_Texture;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
