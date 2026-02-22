using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A8 RID: 168
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00036674 File Offset: 0x00034874
		// Note: this type is marked as 'beforefieldinit'.
		static NameValueCollection()
		{
			Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NameValueCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr);
			NameValueCollection.NativeFieldInfoPtr__all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, "_all");
			NameValueCollection.NativeFieldInfoPtr__allKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, "_allKeys");
			NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664664);
			NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664665);
			NameValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664666);
			NameValueCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664667);
			NameValueCollection.NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664668);
			NameValueCollection.NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664669);
			NameValueCollection.NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664670);
			NameValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664671);
			NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664672);
			NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664673);
			NameValueCollection.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664674);
			NameValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664675);
			NameValueCollection.NativeMethodInfoPtr_get_Item_Public_get_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664676);
			NameValueCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664677);
			NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664678);
			NameValueCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100664679);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0003680C File Offset: 0x00034A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44303, XrefRangeEnd = 44326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00036848 File Offset: 0x00034A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44331, RefRangeEnd = 44333, XrefRangeStart = 44326, XrefRangeEnd = 44331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000368A4 File Offset: 0x00034AA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 44337, RefRangeEnd = 44341, XrefRangeStart = 44333, XrefRangeEnd = 44337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(DBNull dummy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000368F0 File Offset: 0x00034AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44341, XrefRangeEnd = 44345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00036954 File Offset: 0x00034B54
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 44345, RefRangeEnd = 44353, XrefRangeStart = 44345, XrefRangeEnd = 44345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidateCachedArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00036988 File Offset: 0x00034B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44363, RefRangeEnd = 44365, XrefRangeStart = 44353, XrefRangeEnd = 44363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAsOneString(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000369C4 File Offset: 0x00034BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44365, XrefRangeEnd = 44368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetAsStringArray(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00036A08 File Offset: 0x00034C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44368, XrefRangeEnd = 44371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00036A68 File Offset: 0x00034C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44371, XrefRangeEnd = 44377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00036ABC File Offset: 0x00034CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44377, XrefRangeEnd = 44384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetValues(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00036B18 File Offset: 0x00034D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44384, XrefRangeEnd = 44390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Set(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00036B78 File Offset: 0x00034D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44390, XrefRangeEnd = 44391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000316 RID: 790
		public unsafe string this[string name]
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44391, RefRangeEnd = 44405, XrefRangeStart = 44391, XrefRangeEnd = 44391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_get_Item_Public_get_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44405, RefRangeEnd = 44407, XrefRangeStart = 44405, XrefRangeEnd = 44405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00036C64 File Offset: 0x00034E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44407, XrefRangeEnd = 44415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00036CB4 File Offset: 0x00034EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44415, XrefRangeEnd = 44416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00006161 File Offset: 0x00004361
		public NameValueCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00036D04 File Offset: 0x00034F04
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0000616A File Offset: 0x0000436A
		public unsafe Il2CppStringArray _all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00036D34 File Offset: 0x00034F34
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00006189 File Offset: 0x00004389
		public unsafe Il2CppStringArray _allKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__allKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__allKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr__all;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr__allKeys;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_String_String_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0;
	}
}
