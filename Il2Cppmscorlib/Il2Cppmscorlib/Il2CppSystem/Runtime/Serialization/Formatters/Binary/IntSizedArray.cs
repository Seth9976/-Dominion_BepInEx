using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000384 RID: 900
	[Serializable]
	public sealed class IntSizedArray : Object
	{
		// Token: 0x06003AA6 RID: 15014 RVA: 0x001163E0 File Offset: 0x001145E0
		// Note: this type is marked as 'beforefieldinit'.
		static IntSizedArray()
		{
			Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IntSizedArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr);
			IntSizedArray.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "objects");
			IntSizedArray.NativeFieldInfoPtr_negObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "negObjects");
			IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672020);
			IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672021);
			IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672022);
			IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672023);
			IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672024);
			IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672025);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x001164B0 File Offset: 0x001146B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348611, XrefRangeEnd = 348617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x001164EC File Offset: 0x001146EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348617, XrefRangeEnd = 348630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray(IntSizedArray sizedArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sizedArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00116538 File Offset: 0x00114738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348630, XrefRangeEnd = 348645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000E8F RID: 3727
		public unsafe int this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348645, XrefRangeEnd = 348646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348646, XrefRangeEnd = 348647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00116610 File Offset: 0x00114810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348662, RefRangeEnd = 348663, XrefRangeStart = 348647, XrefRangeEnd = 348662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00015EFA File Offset: 0x000140FA
		public IntSizedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x00116650 File Offset: 0x00114850
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x00015F03 File Offset: 0x00014103
		public unsafe Il2CppStructArray<int> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x00116680 File Offset: 0x00114880
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x00015F22 File Offset: 0x00014122
		public unsafe Il2CppStructArray<int> negObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeFieldInfoPtr_negObjects;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0;
	}
}
