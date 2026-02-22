using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000383 RID: 899
	[Serializable]
	public sealed class SizedArray : Object
	{
		// Token: 0x06003A99 RID: 15001 RVA: 0x001160B0 File Offset: 0x001142B0
		// Note: this type is marked as 'beforefieldinit'.
		static SizedArray()
		{
			Il2CppClassPointerStore<SizedArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SizedArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SizedArray>.NativeClassPtr);
			SizedArray.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, "objects");
			SizedArray.NativeFieldInfoPtr_negObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, "negObjects");
			SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672013);
			SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672014);
			SizedArray.NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672015);
			SizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672016);
			SizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672017);
			SizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672018);
			SizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SizedArray>.NativeClassPtr, 100672019);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00116194 File Offset: 0x00114394
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 348544, RefRangeEnd = 348550, XrefRangeStart = 348538, XrefRangeEnd = 348544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x001161D0 File Offset: 0x001143D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 348556, RefRangeEnd = 348560, XrefRangeStart = 348550, XrefRangeEnd = 348556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00116218 File Offset: 0x00114418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348560, XrefRangeEnd = 348569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SizedArray(SizedArray sizedArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sizedArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00116264 File Offset: 0x00114464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348569, XrefRangeEnd = 348580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000E8C RID: 3724
		public unsafe Object this[int index]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 348581, RefRangeEnd = 348588, XrefRangeStart = 348580, XrefRangeEnd = 348581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 348590, RefRangeEnd = 348595, XrefRangeStart = 348588, XrefRangeEnd = 348590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00116340 File Offset: 0x00114540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348610, RefRangeEnd = 348611, XrefRangeStart = 348595, XrefRangeEnd = 348610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00015EB3 File Offset: 0x000140B3
		public SizedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x00116380 File Offset: 0x00114580
		// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x00015EBC File Offset: 0x000140BC
		public unsafe Il2CppReferenceArray<Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x001163B0 File Offset: 0x001145B0
		// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x00015EDB File Offset: 0x000140DB
		public unsafe Il2CppReferenceArray<Object> negObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_negObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SizedArray.NativeFieldInfoPtr_negObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeFieldInfoPtr_negObjects;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SizedArray_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0;
	}
}
