using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Foundation.Templates;

namespace SA.Foundation.Tests
{
	// Token: 0x02000002 RID: 2
	public class SA_BaseTest : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000022E8 File Offset: 0x000004E8
		// Note: this type is marked as 'beforefieldinit'.
		static SA_BaseTest()
		{
			Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_BaseTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr);
			SA_BaseTest.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, "m_result");
			SA_BaseTest.NativeFieldInfoPtr_OnResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, "OnResult");
			SA_BaseTest.NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_2_SA_BaseTest_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663297);
			SA_BaseTest.NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_2_SA_BaseTest_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663298);
			SA_BaseTest.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663299);
			SA_BaseTest.NativeMethodInfoPtr_get_RequireUserInteraction_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663300);
			SA_BaseTest.NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663301);
			SA_BaseTest.NativeMethodInfoPtr_SetResult_Protected_Void_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663302);
			SA_BaseTest.NativeMethodInfoPtr_SetAPIResult_Protected_Void_SA_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663303);
			SA_BaseTest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000023E0 File Offset: 0x000005E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158603, XrefRangeEnd = 158607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnResult(Action<SA_BaseTest, SA_TestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_2_SA_BaseTest_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002424 File Offset: 0x00000624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158607, XrefRangeEnd = 158611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnResult(Action<SA_BaseTest, SA_TestResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_2_SA_BaseTest_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002468 File Offset: 0x00000668
		[CallerCount(0)]
		public unsafe virtual void Test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_BaseTest.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe virtual bool RequireUserInteraction
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_BaseTest.NativeMethodInfoPtr_get_RequireUserInteraction_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000024EC File Offset: 0x000006EC
		public unsafe virtual string Title
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_BaseTest.NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002530 File Offset: 0x00000730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158611, XrefRangeEnd = 158615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult(SA_TestResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.NativeMethodInfoPtr_SetResult_Protected_Void_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002574 File Offset: 0x00000774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158615, XrefRangeEnd = 158631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAPIResult(SA_Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.NativeMethodInfoPtr_SetAPIResult_Protected_Void_SA_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000025B8 File Offset: 0x000007B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158648, RefRangeEnd = 158651, XrefRangeStart = 158631, XrefRangeEnd = 158648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_BaseTest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		public SA_BaseTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000025F4 File Offset: 0x000007F4
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe SA_TestResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_BaseTest.NativeFieldInfoPtr_m_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_TestResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_BaseTest.NativeFieldInfoPtr_m_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe Action<SA_BaseTest, SA_TestResult> OnResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_BaseTest.NativeFieldInfoPtr_OnResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SA_BaseTest, SA_TestResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_BaseTest.NativeFieldInfoPtr_OnResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_OnResult;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_2_SA_BaseTest_SA_TestResult_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_2_SA_BaseTest_SA_TestResult_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_RequireUserInteraction_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_Virtual_New_get_String_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Protected_Void_SA_TestResult_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_SetAPIResult_Protected_Void_SA_Result_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200000C RID: 12
		[ObfuscatedName("SA.Foundation.Tests.SA_BaseTest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00003768 File Offset: 0x00001968
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_BaseTest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr);
				SA_BaseTest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr, "<>9");
				SA_BaseTest.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr, "<>9__11_0");
				SA_BaseTest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr, 100663343);
				SA_BaseTest.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_SA_BaseTest_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr, 100663344);
			}

			// Token: 0x06000066 RID: 102 RVA: 0x000037E4 File Offset: 0x000019E4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_BaseTest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00003820 File Offset: 0x00001A20
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__11_0(SA_BaseTest <p0>, SA_TestResult <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BaseTest.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_SA_BaseTest_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000068 RID: 104 RVA: 0x0000229D File Offset: 0x0000049D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00003874 File Offset: 0x00001A74
			// (set) Token: 0x0600006A RID: 106 RVA: 0x000022A6 File Offset: 0x000004A6
			public unsafe static SA_BaseTest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SA_BaseTest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_BaseTest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_BaseTest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600006B RID: 107 RVA: 0x0000389C File Offset: 0x00001A9C
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000022B8 File Offset: 0x000004B8
			public unsafe static Action<SA_BaseTest, SA_TestResult> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SA_BaseTest.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SA_BaseTest, SA_TestResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_BaseTest.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400003F RID: 63
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000040 RID: 64
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04000041 RID: 65
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000042 RID: 66
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_SA_BaseTest_SA_TestResult_0;
		}
	}
}
