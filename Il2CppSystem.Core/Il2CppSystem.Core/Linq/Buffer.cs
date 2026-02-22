using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000F RID: 15
	public sealed class Buffer<TElement> : ValueType
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00005D80 File Offset: 0x00003F80
		// Note: this type is marked as 'beforefieldinit'.
		static Buffer()
		{
			Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Buffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr);
			Buffer<TElement>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "items");
			Buffer<TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "count");
			Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663485);
			Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663486);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005E3C File Offset: 0x0000403C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58564, RefRangeEnd = 58565, XrefRangeStart = 58525, XrefRangeEnd = 58564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Buffer(IEnumerable<TElement> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005E8C File Offset: 0x0000408C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58569, RefRangeEnd = 58570, XrefRangeStart = 58565, XrefRangeEnd = 58569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<TElement> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002378 File Offset: 0x00000578
		public Buffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002381 File Offset: 0x00000581
		public Buffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005EC8 File Offset: 0x000040C8
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002393 File Offset: 0x00000593
		public unsafe Il2CppArrayBase<TElement> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items);
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005EF0 File Offset: 0x000040F0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000023B2 File Offset: 0x000005B2
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0;
	}
}
