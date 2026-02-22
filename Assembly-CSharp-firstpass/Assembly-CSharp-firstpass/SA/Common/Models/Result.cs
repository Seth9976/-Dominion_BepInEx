using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Common.Models
{
	// Token: 0x02000318 RID: 792
	public class Result : Object
	{
		// Token: 0x06002D87 RID: 11655 RVA: 0x000C2114 File Offset: 0x000C0314
		// Note: this type is marked as 'beforefieldinit'.
		static Result()
		{
			Il2CppClassPointerStore<Result>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "Result");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Result>.NativeClassPtr);
			Result.NativeFieldInfoPtr__Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "_Error");
			Result.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669242);
			Result.NativeMethodInfoPtr__ctor_Public_Void_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669243);
			Result.NativeMethodInfoPtr_get_Error_Public_get_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669244);
			Result.NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669245);
			Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669246);
			Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100669247);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000C21D0 File Offset: 0x000C03D0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Result>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000C220C File Offset: 0x000C040C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result(Error error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Result>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr__ctor_Public_Void_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000C2258 File Offset: 0x000C0458
		public unsafe Error Error
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr_get_Error_Public_get_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Error>(intPtr3) : null;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x000C2298 File Offset: 0x000C0498
		public unsafe bool HasError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000C22D4 File Offset: 0x000C04D4
		public unsafe bool IsSucceeded
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 212589, RefRangeEnd = 212612, XrefRangeStart = 212589, XrefRangeEnd = 212589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x000C2310 File Offset: 0x000C0510
		public unsafe bool IsFailed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00011A87 File Offset: 0x0000FC87
		public Result(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x000C234C File Offset: 0x000C054C
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00011A90 File Offset: 0x0000FC90
		public unsafe Error _Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Result.NativeFieldInfoPtr__Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Error>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Result.NativeFieldInfoPtr__Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeFieldInfoPtr__Error;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Error_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_Error_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_get_HasError_Public_get_Boolean_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;
	}
}
