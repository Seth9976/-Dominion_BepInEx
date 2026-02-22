using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000331 RID: 817
	[Serializable]
	public class MemberHolder : Object
	{
		// Token: 0x06003490 RID: 13456 RVA: 0x00101360 File Offset: 0x000FF560
		// Note: this type is marked as 'beforefieldinit'.
		static MemberHolder()
		{
			Il2CppClassPointerStore<MemberHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "MemberHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr);
			MemberHolder.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, "memberType");
			MemberHolder.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, "context");
			MemberHolder.NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100671448);
			MemberHolder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100671449);
			MemberHolder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100671450);
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x001013F4 File Offset: 0x000FF5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342811, RefRangeEnd = 342812, XrefRangeStart = 342810, XrefRangeEnd = 342811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberHolder(Type type, StreamingContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberHolder.NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00101458 File Offset: 0x000FF658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberHolder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x001014A0 File Offset: 0x000FF6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342812, XrefRangeEnd = 342814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberHolder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00012BF6 File Offset: 0x00010DF6
		public MemberHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x001014F8 File Offset: 0x000FF6F8
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x00012BFF File Offset: 0x00010DFF
		public unsafe Type memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x00101528 File Offset: 0x000FF728
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x00012C1E File Offset: 0x00010E1E
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
