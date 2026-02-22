using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Foundation.Tests
{
	// Token: 0x0200000A RID: 10
	public class SA_TestsManager : MonoBehaviour
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003134 File Offset: 0x00001334
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestsManager()
		{
			Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr);
			SA_TestsManager.NativeFieldInfoPtr_m_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "m_config");
			SA_TestsManager.NativeFieldInfoPtr_OnGroupTestStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "OnGroupTestStarted");
			SA_TestsManager.NativeFieldInfoPtr_OnTestStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "OnTestStarted");
			SA_TestsManager.NativeFieldInfoPtr_OnTestResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "OnTestResult");
			SA_TestsManager.NativeFieldInfoPtr_m_testGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "m_testGroups");
			SA_TestsManager.NativeMethodInfoPtr_add_OnGroupTestStarted_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663327);
			SA_TestsManager.NativeMethodInfoPtr_remove_OnGroupTestStarted_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663328);
			SA_TestsManager.NativeMethodInfoPtr_add_OnTestStarted_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663329);
			SA_TestsManager.NativeMethodInfoPtr_remove_OnTestStarted_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663330);
			SA_TestsManager.NativeMethodInfoPtr_add_OnTestResult_Public_Static_add_Void_Action_1_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663331);
			SA_TestsManager.NativeMethodInfoPtr_remove_OnTestResult_Public_Static_rem_Void_Action_1_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663332);
			SA_TestsManager.NativeMethodInfoPtr_get_Config_Public_get_SA_TestSuiteConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663333);
			SA_TestsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663334);
			SA_TestsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000327C File Offset: 0x0000147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158741, XrefRangeEnd = 158752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGroupTestStarted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_add_OnGroupTestStarted_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000032B4 File Offset: 0x000014B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158752, XrefRangeEnd = 158763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGroupTestStarted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_remove_OnGroupTestStarted_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000032EC File Offset: 0x000014EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158763, XrefRangeEnd = 158774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnTestStarted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_add_OnTestStarted_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003324 File Offset: 0x00001524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158774, XrefRangeEnd = 158785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnTestStarted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_remove_OnTestStarted_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000335C File Offset: 0x0000155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158785, XrefRangeEnd = 158796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnTestResult(Action<SA_TestResult> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_add_OnTestResult_Public_Static_add_Void_Action_1_SA_TestResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003394 File Offset: 0x00001594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158796, XrefRangeEnd = 158807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnTestResult(Action<SA_TestResult> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_remove_OnTestResult_Public_Static_rem_Void_Action_1_SA_TestResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000033CC File Offset: 0x000015CC
		public unsafe SA_TestSuiteConfig Config
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_get_Config_Public_get_SA_TestSuiteConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_TestSuiteConfig>(intPtr3) : null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000340C File Offset: 0x0000160C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158807, XrefRangeEnd = 158824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003440 File Offset: 0x00001640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158824, XrefRangeEnd = 158831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestsManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000021F8 File Offset: 0x000003F8
		public SA_TestsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000347C File Offset: 0x0000167C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe SA_TestSuiteConfig m_config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestsManager.NativeFieldInfoPtr_m_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_TestSuiteConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestsManager.NativeFieldInfoPtr_m_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe static Action<string> OnGroupTestStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_TestsManager.NativeFieldInfoPtr_OnGroupTestStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_TestsManager.NativeFieldInfoPtr_OnGroupTestStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000034D4 File Offset: 0x000016D4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002232 File Offset: 0x00000432
		public unsafe static Action<string> OnTestStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_TestsManager.NativeFieldInfoPtr_OnTestStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_TestsManager.NativeFieldInfoPtr_OnTestStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000034FC File Offset: 0x000016FC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe static Action<SA_TestResult> OnTestResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_TestsManager.NativeFieldInfoPtr_OnTestResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SA_TestResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_TestsManager.NativeFieldInfoPtr_OnTestResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003524 File Offset: 0x00001724
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe List<SA_TestGroupConfig> m_testGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestsManager.NativeFieldInfoPtr_m_testGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_TestGroupConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestsManager.NativeFieldInfoPtr_m_testGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_config;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_OnGroupTestStarted;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_OnTestStarted;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_OnTestResult;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_testGroups;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGroupTestStarted_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGroupTestStarted_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTestStarted_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTestStarted_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTestResult_Public_Static_add_Void_Action_1_SA_TestResult_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTestResult_Public_Static_rem_Void_Action_1_SA_TestResult_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_Config_Public_get_SA_TestSuiteConfig_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000E RID: 14
		[ObfuscatedName("SA.Foundation.Tests.SA_TestsManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600006D RID: 109 RVA: 0x000038C4 File Offset: 0x00001AC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_TestsManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr);
				SA_TestsManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr, "<>9");
				SA_TestsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr, 100663346);
				SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr, 100663347);
				SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr, 100663348);
				SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_2_Internal_Void_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr, 100663349);
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00003954 File Offset: 0x00001B54
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestsManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00003990 File Offset: 0x00001B90
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__15_0(string <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000070 RID: 112 RVA: 0x000039D4 File Offset: 0x00001BD4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__15_1(string <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00003A18 File Offset: 0x00001C18
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__15_2(SA_TestResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestsManager.__c.NativeMethodInfoPtr___cctor_b__15_2_Internal_Void_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000072 RID: 114 RVA: 0x000022CA File Offset: 0x000004CA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00003A5C File Offset: 0x00001C5C
			// (set) Token: 0x06000074 RID: 116 RVA: 0x000022D3 File Offset: 0x000004D3
			public unsafe static SA_TestsManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SA_TestsManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_TestsManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_TestsManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000047 RID: 71
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000048 RID: 72
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000049 RID: 73
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_Void_String_0;

			// Token: 0x0400004A RID: 74
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_1_Internal_Void_String_0;

			// Token: 0x0400004B RID: 75
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_2_Internal_Void_SA_TestResult_0;
		}
	}
}
