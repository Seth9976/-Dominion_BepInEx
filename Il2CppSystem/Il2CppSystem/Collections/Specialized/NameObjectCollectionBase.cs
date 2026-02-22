using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public class NameObjectCollectionBase : Object
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x00035900 File Offset: 0x00033B00
		// Note: this type is marked as 'beforefieldinit'.
		static NameObjectCollectionBase()
		{
			Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NameObjectCollectionBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr);
			NameObjectCollectionBase.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_readOnly");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesArray");
			NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_keyComparer");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesTable");
			NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_nullKeyEntry");
			NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_serializationInfo");
			NameObjectCollectionBase.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_version");
			NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "defaultComparer");
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664631);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664632);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664633);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664634);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664635);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664636);
			NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664637);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664638);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664639);
			NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664640);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664641);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664642);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664643);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664644);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664645);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664646);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664647);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664648);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664649);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664650);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00035B60 File Offset: 0x00033D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43937, XrefRangeEnd = 43956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00035B9C File Offset: 0x00033D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43971, RefRangeEnd = 43973, XrefRangeStart = 43956, XrefRangeEnd = 43971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00035BE8 File Offset: 0x00033DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43973, XrefRangeEnd = 43975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00035C44 File Offset: 0x00033E44
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(DBNull dummy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00035C90 File Offset: 0x00033E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43975, XrefRangeEnd = 43976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00035CF4 File Offset: 0x00033EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43976, XrefRangeEnd = 44073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00035D58 File Offset: 0x00033F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44073, XrefRangeEnd = 44177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00035DA8 File Offset: 0x00033FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44177, XrefRangeEnd = 44187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00035DDC File Offset: 0x00033FDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44197, RefRangeEnd = 44200, XrefRangeStart = 44187, XrefRangeEnd = 44197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00035E1C File Offset: 0x0003401C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 44202, RefRangeEnd = 44208, XrefRangeStart = 44200, XrefRangeEnd = 44202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr3) : null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00035E6C File Offset: 0x0003406C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00035EA8 File Offset: 0x000340A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44217, RefRangeEnd = 44220, XrefRangeStart = 44208, XrefRangeEnd = 44217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseAdd(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00035EFC File Offset: 0x000340FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44224, RefRangeEnd = 44225, XrefRangeStart = 44220, XrefRangeEnd = 44224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseRemove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00035F40 File Offset: 0x00034140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44225, XrefRangeEnd = 44226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00035F90 File Offset: 0x00034190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44226, XrefRangeEnd = 44228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseSet(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00035FE4 File Offset: 0x000341E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44228, XrefRangeEnd = 44230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00036030 File Offset: 0x00034230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44232, RefRangeEnd = 44234, XrefRangeStart = 44230, XrefRangeEnd = 44232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BaseGetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00036074 File Offset: 0x00034274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44234, XrefRangeEnd = 44238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000360C0 File Offset: 0x000342C0
		public unsafe virtual int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44239, RefRangeEnd = 44242, XrefRangeStart = 44238, XrefRangeEnd = 44239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00036108 File Offset: 0x00034308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44242, XrefRangeEnd = 44252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000600A File Offset: 0x0000420A
		public NameObjectCollectionBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00036158 File Offset: 0x00034358
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00006013 File Offset: 0x00004213
		public unsafe bool _readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly)) = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00036180 File Offset: 0x00034380
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0000602E File Offset: 0x0000422E
		public unsafe ArrayList _entriesArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000361B0 File Offset: 0x000343B0
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0000604D File Offset: 0x0000424D
		public unsafe IEqualityComparer _keyComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000361E0 File Offset: 0x000343E0
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0000606C File Offset: 0x0000426C
		public unsafe Hashtable _entriesTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00036210 File Offset: 0x00034410
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0000608B File Offset: 0x0000428B
		public unsafe NameObjectCollectionBase.NameObjectEntry _nullKeyEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00036240 File Offset: 0x00034440
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000060AA File Offset: 0x000042AA
		public unsafe SerializationInfo _serializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00036270 File Offset: 0x00034470
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x000060C9 File Offset: 0x000042C9
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00036298 File Offset: 0x00034498
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x000060E4 File Offset: 0x000042E4
		public unsafe static StringComparer defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr__readOnly;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr__entriesArray;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr__keyComparer;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr__entriesTable;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr__nullKeyEntry;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr__serializationInfo;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_Int32_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_String_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0200019D RID: 413
		public class NameObjectEntry : Object
		{
			// Token: 0x0600179D RID: 6045 RVA: 0x00065EB8 File Offset: 0x000640B8
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectEntry()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Key");
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Value");
				NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, 100664652);
			}

			// Token: 0x0600179E RID: 6046 RVA: 0x00065F20 File Offset: 0x00064120
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectEntry(string name, Object value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600179F RID: 6047 RVA: 0x0000C7BE File Offset: 0x0000A9BE
			public NameObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00065F80 File Offset: 0x00064180
			// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00065FA8 File Offset: 0x000641A8
			// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0000C7E6 File Offset: 0x0000A9E6
			public unsafe Object Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0;
		}

		// Token: 0x0200019E RID: 414
		[Serializable]
		public class NameObjectKeysEnumerator : Object
		{
			// Token: 0x060017A4 RID: 6052 RVA: 0x00065FD8 File Offset: 0x000641D8
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectKeysEnumerator()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectKeysEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_pos");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_coll");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_version");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664653);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664654);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664655);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664656);
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x00066090 File Offset: 0x00064290
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 43926, RefRangeEnd = 43928, XrefRangeStart = 43925, XrefRangeEnd = 43926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectKeysEnumerator(NameObjectCollectionBase coll)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017A6 RID: 6054 RVA: 0x000660DC File Offset: 0x000642DC
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x00066118 File Offset: 0x00064318
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0006614C File Offset: 0x0006434C
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43928, XrefRangeEnd = 43937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x0000C805 File Offset: 0x0000AA05
			public NameObjectKeysEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x060017AA RID: 6058 RVA: 0x0006618C File Offset: 0x0006438C
			// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000C80E File Offset: 0x0000AA0E
			public unsafe int _pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos)) = value;
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x060017AC RID: 6060 RVA: 0x000661B4 File Offset: 0x000643B4
			// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000C829 File Offset: 0x0000AA29
			public unsafe NameObjectCollectionBase _coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x060017AE RID: 6062 RVA: 0x000661E4 File Offset: 0x000643E4
			// (set) Token: 0x060017AF RID: 6063 RVA: 0x0000C848 File Offset: 0x0000AA48
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeFieldInfoPtr__pos;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeFieldInfoPtr__coll;

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0;

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
