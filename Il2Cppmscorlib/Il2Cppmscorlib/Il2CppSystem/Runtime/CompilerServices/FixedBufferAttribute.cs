using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042F RID: 1071
	public sealed class FixedBufferAttribute : Attribute
	{
		// Token: 0x0600423D RID: 16957 RVA: 0x0013122C File Offset: 0x0012F42C
		// Note: this type is marked as 'beforefieldinit'.
		static FixedBufferAttribute()
		{
			Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FixedBufferAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr);
			FixedBufferAttribute.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "elementType");
			FixedBufferAttribute.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "length");
			FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100672930);
			FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100672931);
			FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100672932);
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x001312C0 File Offset: 0x0012F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedBufferAttribute(Type elementType, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x0013131C File Offset: 0x0012F51C
		public unsafe Type ElementType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x0013135C File Offset: 0x0012F55C
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00019477 File Offset: 0x00017677
		public FixedBufferAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x00131398 File Offset: 0x0012F598
		// (set) Token: 0x06004243 RID: 16963 RVA: 0x00019480 File Offset: 0x00017680
		public unsafe Type elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x001313C8 File Offset: 0x0012F5C8
		// (set) Token: 0x06004245 RID: 16965 RVA: 0x0001949F File Offset: 0x0001769F
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Public_get_Type_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
	}
}
