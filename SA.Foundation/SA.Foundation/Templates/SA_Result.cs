using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Templates
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class SA_Result : Object
	{
		// Token: 0x060000EB RID: 235 RVA: 0x0000747C File Offset: 0x0000567C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Result()
		{
			Il2CppClassPointerStore<SA_Result>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Templates", "SA_Result");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Result>.NativeClassPtr);
			SA_Result.NativeFieldInfoPtr_m_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, "m_error");
			SA_Result.NativeFieldInfoPtr_m_requestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, "m_requestId");
			SA_Result.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663451);
			SA_Result.NativeMethodInfoPtr__ctor_Public_Void_SA_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663452);
			SA_Result.NativeMethodInfoPtr_SetError_Public_Void_SA_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663453);
			SA_Result.NativeMethodInfoPtr_get_Error_Public_get_SA_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663454);
			SA_Result.NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663455);
			SA_Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663456);
			SA_Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663457);
			SA_Result.NativeMethodInfoPtr_get_RequestId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663458);
			SA_Result.NativeMethodInfoPtr_set_RequestId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663459);
			SA_Result.NativeMethodInfoPtr_ToJson_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Result>.NativeClassPtr, 100663460);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000759C File Offset: 0x0000579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99576, XrefRangeEnd = 99579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Result()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Result>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000075D8 File Offset: 0x000057D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99582, RefRangeEnd = 99583, XrefRangeStart = 99579, XrefRangeEnd = 99582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Result(SA_Error error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Result>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr__ctor_Public_Void_SA_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007624 File Offset: 0x00005824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetError(SA_Error error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_SetError_Public_Void_SA_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00007668 File Offset: 0x00005868
		public unsafe SA_Error Error
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_get_Error_Public_get_SA_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_Error>(intPtr3) : null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000076A8 File Offset: 0x000058A8
		public unsafe bool HasError
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 99584, RefRangeEnd = 99587, XrefRangeStart = 99583, XrefRangeEnd = 99584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000076E4 File Offset: 0x000058E4
		public unsafe bool IsSucceeded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99587, XrefRangeEnd = 99588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00007720 File Offset: 0x00005920
		public unsafe bool IsFailed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 99584, RefRangeEnd = 99587, XrefRangeStart = 99584, XrefRangeEnd = 99587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000775C File Offset: 0x0000595C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00007794 File Offset: 0x00005994
		public unsafe string RequestId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_get_RequestId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_set_RequestId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000077D8 File Offset: 0x000059D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99588, XrefRangeEnd = 99589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Result.NativeMethodInfoPtr_ToJson_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002333 File Offset: 0x00000533
		public SA_Result(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00007810 File Offset: 0x00005A10
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe SA_Error m_error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Result.NativeFieldInfoPtr_m_error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Error>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Result.NativeFieldInfoPtr_m_error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00007840 File Offset: 0x00005A40
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000235B File Offset: 0x0000055B
		public unsafe string m_requestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Result.NativeFieldInfoPtr_m_requestId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Result.NativeFieldInfoPtr_m_requestId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_error;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_requestId;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SA_Error_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SetError_Public_Void_SA_Error_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_SA_Error_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestId_Public_get_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestId_Public_set_Void_String_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_String_0;
	}
}
