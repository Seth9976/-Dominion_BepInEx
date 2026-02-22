using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000345 RID: 837
	public class StopSessionRequest : Object
	{
		// Token: 0x060032A3 RID: 12963 RVA: 0x000D371C File Offset: 0x000D191C
		// Note: this type is marked as 'beforefieldinit'.
		static StopSessionRequest()
		{
			Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "StopSessionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr);
			StopSessionRequest.NativeFieldInfoPtr_OnSessionStopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, "OnSessionStopped");
			StopSessionRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, "id");
			StopSessionRequest.NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, "sessionId");
			StopSessionRequest.NativeMethodInfoPtr_add_OnSessionStopped_Public_add_Void_Action_1_StopSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669791);
			StopSessionRequest.NativeMethodInfoPtr_remove_OnSessionStopped_Public_rem_Void_Action_1_StopSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669792);
			StopSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669793);
			StopSessionRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669794);
			StopSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669795);
			StopSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, 100669796);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000D3800 File Offset: 0x000D1A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222645, RefRangeEnd = 222646, XrefRangeStart = 222641, XrefRangeEnd = 222645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSessionStopped(Action<StopSessionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr_add_OnSessionStopped_Public_add_Void_Action_1_StopSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000D3844 File Offset: 0x000D1A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222646, XrefRangeEnd = 222650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSessionStopped(Action<StopSessionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr_remove_OnSessionStopped_Public_rem_Void_Action_1_StopSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000D3888 File Offset: 0x000D1A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222670, RefRangeEnd = 222671, XrefRangeStart = 222650, XrefRangeEnd = 222670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopSessionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000D38C4 File Offset: 0x000D1AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222747, RefRangeEnd = 222748, XrefRangeStart = 222671, XrefRangeEnd = 222747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000D3908 File Offset: 0x000D1B08
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x000D3944 File Offset: 0x000D1B44
		public unsafe string SessionId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00013B03 File Offset: 0x00011D03
		public StopSessionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x000D397C File Offset: 0x000D1B7C
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x00013B0C File Offset: 0x00011D0C
		public unsafe Action<StopSessionResult> OnSessionStopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_OnSessionStopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StopSessionResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_OnSessionStopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x000D39AC File Offset: 0x000D1BAC
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x00013B2B File Offset: 0x00011D2B
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x000D39D4 File Offset: 0x000D1BD4
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x00013B46 File Offset: 0x00011D46
		public unsafe string sessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_sessionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.NativeFieldInfoPtr_sessionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeFieldInfoPtr_OnSessionStopped;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr_sessionId;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSessionStopped_Public_add_Void_Action_1_StopSessionResult_0;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSessionStopped_Public_rem_Void_Action_1_StopSessionResult_0;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_String_0;

		// Token: 0x020003EF RID: 1007
		public class Builder : Object
		{
			// Token: 0x060039D3 RID: 14803 RVA: 0x000EA214 File Offset: 0x000E8414
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr);
				StopSessionRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr, "request");
				StopSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr, 100670586);
				StopSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr, 100670587);
				StopSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_StopSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr, 100670588);
			}

			// Token: 0x060039D4 RID: 14804 RVA: 0x000EA290 File Offset: 0x000E8490
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222640, RefRangeEnd = 222641, XrefRangeStart = 222635, XrefRangeEnd = 222640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSessionRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039D5 RID: 14805 RVA: 0x000EA2CC File Offset: 0x000E84CC
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StopSessionRequest.Builder SetIdentifier(string sessionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(sessionId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StopSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039D6 RID: 14806 RVA: 0x000EA31C File Offset: 0x000E851C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StopSessionRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_StopSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StopSessionRequest>(intPtr3) : null;
			}

			// Token: 0x060039D7 RID: 14807 RVA: 0x0001659B File Offset: 0x0001479B
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x060039D8 RID: 14808 RVA: 0x000EA35C File Offset: 0x000E855C
			// (set) Token: 0x060039D9 RID: 14809 RVA: 0x000165A4 File Offset: 0x000147A4
			public unsafe StopSessionRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopSessionRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSessionRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033D0 RID: 13264
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033D1 RID: 13265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033D2 RID: 13266
			private static readonly IntPtr NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0;

			// Token: 0x040033D3 RID: 13267
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_StopSessionRequest_0;
		}

		// Token: 0x020003F0 RID: 1008
		[ObfuscatedName("SA.Fitness.StopSessionRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039DA RID: 14810 RVA: 0x000EA38C File Offset: 0x000E858C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StopSessionRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr);
				StopSessionRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr, "<>9");
				StopSessionRequest.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr, "<>9__5_0");
				StopSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr, 100670590);
				StopSessionRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_StopSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr, 100670591);
			}

			// Token: 0x060039DB RID: 14811 RVA: 0x000EA408 File Offset: 0x000E8608
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSessionRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x000EA444 File Offset: 0x000E8644
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(StopSessionResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSessionRequest.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_StopSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x000165C3 File Offset: 0x000147C3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB0 RID: 3504
			// (get) Token: 0x060039DE RID: 14814 RVA: 0x000EA488 File Offset: 0x000E8688
			// (set) Token: 0x060039DF RID: 14815 RVA: 0x000165CC File Offset: 0x000147CC
			public unsafe static StopSessionRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StopSessionRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopSessionRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StopSessionRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x060039E0 RID: 14816 RVA: 0x000EA4B0 File Offset: 0x000E86B0
			// (set) Token: 0x060039E1 RID: 14817 RVA: 0x000165DE File Offset: 0x000147DE
			public unsafe static Action<StopSessionResult> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StopSessionRequest.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StopSessionResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StopSessionRequest.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033D4 RID: 13268
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033D5 RID: 13269
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040033D6 RID: 13270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033D7 RID: 13271
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_StopSessionResult_0;
		}
	}
}
