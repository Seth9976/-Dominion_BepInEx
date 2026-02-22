using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000474 RID: 1140
	[Serializable]
	public class Hashtable : Object
	{
		// Token: 0x0600442E RID: 17454 RVA: 0x00137E58 File Offset: 0x00136058
		// Note: this type is marked as 'beforefieldinit'.
		static Hashtable()
		{
			Il2CppClassPointerStore<Hashtable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Hashtable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable>.NativeClassPtr);
			Hashtable.NativeFieldInfoPtr_HashPrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashPrime");
			Hashtable.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "InitialSize");
			Hashtable.NativeFieldInfoPtr_LoadFactorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "LoadFactorName");
			Hashtable.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "VersionName");
			Hashtable.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ComparerName");
			Hashtable.NativeFieldInfoPtr_HashCodeProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashCodeProviderName");
			Hashtable.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashSizeName");
			Hashtable.NativeFieldInfoPtr_KeysName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeysName");
			Hashtable.NativeFieldInfoPtr_ValuesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValuesName");
			Hashtable.NativeFieldInfoPtr_KeyComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyComparerName");
			Hashtable.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "buckets");
			Hashtable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "count");
			Hashtable.NativeFieldInfoPtr_occupancy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "occupancy");
			Hashtable.NativeFieldInfoPtr_loadsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "loadsize");
			Hashtable.NativeFieldInfoPtr_loadFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "loadFactor");
			Hashtable.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "version");
			Hashtable.NativeFieldInfoPtr_isWriterInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "isWriterInProgress");
			Hashtable.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "keys");
			Hashtable.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "values");
			Hashtable.NativeFieldInfoPtr__keycomparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_keycomparer");
			Hashtable.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_syncRoot");
			Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673202);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673203);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673204);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673205);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673206);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673207);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673208);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673209);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673210);
			Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673211);
			Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673212);
			Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673213);
			Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673214);
			Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673215);
			Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673216);
			Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673217);
			Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673218);
			Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673219);
			Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673220);
			Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673221);
			Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673222);
			Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673223);
			Hashtable.NativeMethodInfoPtr_expand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673224);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673225);
			Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673226);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673227);
			Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673228);
			Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673229);
			Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673230);
			Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673231);
			Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673232);
			Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673233);
			Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673234);
			Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673235);
			Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673236);
			Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673237);
			Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673238);
			Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673239);
			Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673240);
			Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673241);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x0013834C File Offset: 0x0013654C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(bool trash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00138394 File Offset: 0x00136594
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 359863, RefRangeEnd = 359905, XrefRangeStart = 359862, XrefRangeEnd = 359863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x001383D0 File Offset: 0x001365D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 359906, RefRangeEnd = 359915, XrefRangeStart = 359905, XrefRangeEnd = 359906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00138418 File Offset: 0x00136618
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 359925, RefRangeEnd = 359939, XrefRangeStart = 359915, XrefRangeEnd = 359925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00138470 File Offset: 0x00136670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359939, XrefRangeEnd = 359945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x001384EC File Offset: 0x001366EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359945, XrefRangeEnd = 359946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00138554 File Offset: 0x00136754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359948, RefRangeEnd = 359950, XrefRangeStart = 359946, XrefRangeEnd = 359948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001385B4 File Offset: 0x001367B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 359951, RefRangeEnd = 359956, XrefRangeStart = 359950, XrefRangeEnd = 359951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x00138600 File Offset: 0x00136800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359957, RefRangeEnd = 359959, XrefRangeStart = 359956, XrefRangeEnd = 359957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0013865C File Offset: 0x0013685C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359968, RefRangeEnd = 359969, XrefRangeStart = 359959, XrefRangeEnd = 359968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x001386C0 File Offset: 0x001368C0
		[CallerCount(0)]
		public unsafe uint InitHash(Object key, int hashsize, out uint seed, out uint incr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashsize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &seed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &incr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00138738 File Offset: 0x00136938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359969, XrefRangeEnd = 359970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00138798 File Offset: 0x00136998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359970, XrefRangeEnd = 359977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x001387D4 File Offset: 0x001369D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359977, XrefRangeEnd = 359983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00138820 File Offset: 0x00136A20
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00138878 File Offset: 0x00136A78
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001388D0 File Offset: 0x00136AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359984, RefRangeEnd = 359985, XrefRangeStart = 359983, XrefRangeEnd = 359984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyKeys(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00138920 File Offset: 0x00136B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359985, XrefRangeEnd = 359990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyEntries(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00138970 File Offset: 0x00136B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359990, XrefRangeEnd = 359997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x001389CC File Offset: 0x00136BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359998, RefRangeEnd = 359999, XrefRangeStart = 359997, XrefRangeEnd = 359998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValues(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001170 RID: 4464
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359999, XrefRangeEnd = 360003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360003, XrefRangeEnd = 360004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00138AD8 File Offset: 0x00136CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360004, XrefRangeEnd = 360014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void expand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_expand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00138B0C File Offset: 0x00136D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360014, XrefRangeEnd = 360016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00138B40 File Offset: 0x00136D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360016, XrefRangeEnd = 360018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00138B74 File Offset: 0x00136D74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360033, RefRangeEnd = 360036, XrefRangeStart = 360018, XrefRangeEnd = 360033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash(int newsize, bool forceNewHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newsize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceNewHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00138BC0 File Offset: 0x00136DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360036, XrefRangeEnd = 360040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00138C00 File Offset: 0x00136E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360040, XrefRangeEnd = 360044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00138C4C File Offset: 0x00136E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360044, XrefRangeEnd = 360049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHash(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00138CA4 File Offset: 0x00136EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360049, XrefRangeEnd = 360053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool KeyEquals(Object item, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x00138D10 File Offset: 0x00136F10
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360053, XrefRangeEnd = 360057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x00138D5C File Offset: 0x00136F5C
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360057, XrefRangeEnd = 360061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00138DA8 File Offset: 0x00136FA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360140, RefRangeEnd = 360143, XrefRangeStart = 360061, XrefRangeEnd = 360140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(Object key, Object nvalue, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00138E0C File Offset: 0x0013700C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360144, RefRangeEnd = 360145, XrefRangeStart = 360143, XrefRangeEnd = 360144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void putEntry(Il2CppReferenceArray<Hashtable.bucket> newBuckets, Object key, Object nvalue, int hashcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newBuckets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00138E80 File Offset: 0x00137080
		[CallerCount(0)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x00138ED0 File Offset: 0x001370D0
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360145, XrefRangeEnd = 360150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x00138F1C File Offset: 0x0013711C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00138F64 File Offset: 0x00137164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360154, RefRangeEnd = 360155, XrefRangeStart = 360150, XrefRangeEnd = 360154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable Synchronized(Hashtable table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00138FA8 File Offset: 0x001371A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360155, XrefRangeEnd = 360229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x0013900C File Offset: 0x0013720C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360229, XrefRangeEnd = 360345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x0001A228 File Offset: 0x00018428
		public Hashtable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x0013905C File Offset: 0x0013725C
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x0001A231 File Offset: 0x00018431
		public unsafe static int HashPrime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&value));
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x00139078 File Offset: 0x00137278
		// (set) Token: 0x0600445B RID: 17499 RVA: 0x0001A23F File Offset: 0x0001843F
		public unsafe static int InitialSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&value));
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x00139094 File Offset: 0x00137294
		// (set) Token: 0x0600445D RID: 17501 RVA: 0x0001A24D File Offset: 0x0001844D
		public unsafe static string LoadFactorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x001390B4 File Offset: 0x001372B4
		// (set) Token: 0x0600445F RID: 17503 RVA: 0x0001A25F File Offset: 0x0001845F
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x001390D4 File Offset: 0x001372D4
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x0001A271 File Offset: 0x00018471
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x001390F4 File Offset: 0x001372F4
		// (set) Token: 0x06004463 RID: 17507 RVA: 0x0001A283 File Offset: 0x00018483
		public unsafe static string HashCodeProviderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x00139114 File Offset: 0x00137314
		// (set) Token: 0x06004465 RID: 17509 RVA: 0x0001A295 File Offset: 0x00018495
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x00139134 File Offset: 0x00137334
		// (set) Token: 0x06004467 RID: 17511 RVA: 0x0001A2A7 File Offset: 0x000184A7
		public unsafe static string KeysName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeysName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeysName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x00139154 File Offset: 0x00137354
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x0001A2B9 File Offset: 0x000184B9
		public unsafe static string ValuesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ValuesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ValuesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x00139174 File Offset: 0x00137374
		// (set) Token: 0x0600446B RID: 17515 RVA: 0x0001A2CB File Offset: 0x000184CB
		public unsafe static string KeyComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x00139194 File Offset: 0x00137394
		// (set) Token: 0x0600446D RID: 17517 RVA: 0x0001A2DD File Offset: 0x000184DD
		public unsafe Il2CppReferenceArray<Hashtable.bucket> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Hashtable.bucket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x001391C4 File Offset: 0x001373C4
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x0001A2FC File Offset: 0x000184FC
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x001391EC File Offset: 0x001373EC
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x0001A317 File Offset: 0x00018517
		public unsafe int occupancy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_occupancy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_occupancy)) = value;
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x00139214 File Offset: 0x00137414
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x0001A332 File Offset: 0x00018532
		public unsafe int loadsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadsize)) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x0013923C File Offset: 0x0013743C
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x0001A34D File Offset: 0x0001854D
		public unsafe float loadFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadFactor)) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x00139264 File Offset: 0x00137464
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x0001A368 File Offset: 0x00018568
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x0013928C File Offset: 0x0013748C
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x0001A383 File Offset: 0x00018583
		public unsafe bool isWriterInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_isWriterInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_isWriterInProgress)) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x001392B4 File Offset: 0x001374B4
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x0001A39E File Offset: 0x0001859E
		public unsafe ICollection keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x001392E4 File Offset: 0x001374E4
		// (set) Token: 0x0600447D RID: 17533 RVA: 0x0001A3BD File Offset: 0x000185BD
		public unsafe ICollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x00139314 File Offset: 0x00137514
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x0001A3DC File Offset: 0x000185DC
		public unsafe IEqualityComparer _keycomparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x00139344 File Offset: 0x00137544
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x0001A3FB File Offset: 0x000185FB
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeFieldInfoPtr_HashPrime;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeFieldInfoPtr_LoadFactorName;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeFieldInfoPtr_HashCodeProviderName;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeFieldInfoPtr_KeysName;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeFieldInfoPtr_ValuesName;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeFieldInfoPtr_KeyComparerName;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeFieldInfoPtr_occupancy;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeFieldInfoPtr_loadsize;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeFieldInfoPtr_loadFactor;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeFieldInfoPtr_isWriterInProgress;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeFieldInfoPtr__keycomparer;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_expand_Private_Void_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Private_Void_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x0200064D RID: 1613
		public sealed class bucket : ValueType
		{
			// Token: 0x06005506 RID: 21766 RVA: 0x00177D08 File Offset: 0x00175F08
			// Note: this type is marked as 'beforefieldinit'.
			static bucket()
			{
				Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "bucket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr);
				Hashtable.bucket.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "key");
				Hashtable.bucket.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "val");
				Hashtable.bucket.NativeFieldInfoPtr_hash_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "hash_coll");
			}

			// Token: 0x06005507 RID: 21767 RVA: 0x00020CB8 File Offset: 0x0001EEB8
			public bucket(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005508 RID: 21768 RVA: 0x00020CC1 File Offset: 0x0001EEC1
			public bucket()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr))
			{
			}

			// Token: 0x170015C6 RID: 5574
			// (get) Token: 0x06005509 RID: 21769 RVA: 0x00177D70 File Offset: 0x00175F70
			// (set) Token: 0x0600550A RID: 21770 RVA: 0x00020CD3 File Offset: 0x0001EED3
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C7 RID: 5575
			// (get) Token: 0x0600550B RID: 21771 RVA: 0x00177DA0 File Offset: 0x00175FA0
			// (set) Token: 0x0600550C RID: 21772 RVA: 0x00020CF2 File Offset: 0x0001EEF2
			public unsafe Object val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C8 RID: 5576
			// (get) Token: 0x0600550D RID: 21773 RVA: 0x00177DD0 File Offset: 0x00175FD0
			// (set) Token: 0x0600550E RID: 21774 RVA: 0x00020D11 File Offset: 0x0001EF11
			public unsafe int hash_coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll)) = value;
				}
			}

			// Token: 0x0400445A RID: 17498
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400445B RID: 17499
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x0400445C RID: 17500
			private static readonly IntPtr NativeFieldInfoPtr_hash_coll;
		}

		// Token: 0x0200064E RID: 1614
		[Serializable]
		public class KeyCollection : Object
		{
			// Token: 0x0600550F RID: 21775 RVA: 0x00177DF8 File Offset: 0x00175FF8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr);
				Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, "_hashtable");
				Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673242);
				Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673243);
				Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673244);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673245);
			}

			// Token: 0x06005510 RID: 21776 RVA: 0x00177E88 File Offset: 0x00176088
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005511 RID: 21777 RVA: 0x00177ED4 File Offset: 0x001760D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359709, XrefRangeEnd = 359741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005512 RID: 21778 RVA: 0x00177F30 File Offset: 0x00176130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359741, XrefRangeEnd = 359746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x170015CA RID: 5578
			// (get) Token: 0x06005513 RID: 21779 RVA: 0x00177F7C File Offset: 0x0017617C
			public unsafe virtual int Count
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005514 RID: 21780 RVA: 0x00020D2C File Offset: 0x0001EF2C
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C9 RID: 5577
			// (get) Token: 0x06005515 RID: 21781 RVA: 0x00177FC4 File Offset: 0x001761C4
			// (set) Token: 0x06005516 RID: 21782 RVA: 0x00020D35 File Offset: 0x0001EF35
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400445D RID: 17501
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x0400445E RID: 17502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x0400445F RID: 17503
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004460 RID: 17504
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004461 RID: 17505
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x0200064F RID: 1615
		[Serializable]
		public class ValueCollection : Object
		{
			// Token: 0x06005517 RID: 21783 RVA: 0x00177FF4 File Offset: 0x001761F4
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr);
				Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, "_hashtable");
				Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673246);
				Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673247);
				Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673248);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673249);
			}

			// Token: 0x06005518 RID: 21784 RVA: 0x00178084 File Offset: 0x00176284
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005519 RID: 21785 RVA: 0x001780D0 File Offset: 0x001762D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359746, XrefRangeEnd = 359778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600551A RID: 21786 RVA: 0x0017812C File Offset: 0x0017632C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359778, XrefRangeEnd = 359783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x170015CC RID: 5580
			// (get) Token: 0x0600551B RID: 21787 RVA: 0x00178178 File Offset: 0x00176378
			public unsafe virtual int Count
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600551C RID: 21788 RVA: 0x00020D54 File Offset: 0x0001EF54
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CB RID: 5579
			// (get) Token: 0x0600551D RID: 21789 RVA: 0x001781C0 File Offset: 0x001763C0
			// (set) Token: 0x0600551E RID: 21790 RVA: 0x00020D5D File Offset: 0x0001EF5D
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004462 RID: 17506
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x04004463 RID: 17507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x04004464 RID: 17508
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004465 RID: 17509
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004466 RID: 17510
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x02000650 RID: 1616
		[Serializable]
		public class SyncHashtable : Hashtable
		{
			// Token: 0x0600551F RID: 21791 RVA: 0x001781F0 File Offset: 0x001763F0
			// Note: this type is marked as 'beforefieldinit'.
			static SyncHashtable()
			{
				Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "SyncHashtable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr);
				Hashtable.SyncHashtable.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, "_table");
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673250);
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673251);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673252);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673253);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673254);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673255);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673256);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673257);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673258);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673259);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673260);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673261);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673262);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673263);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673264);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673265);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673266);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673267);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673268);
			}

			// Token: 0x06005520 RID: 21792 RVA: 0x001783AC File Offset: 0x001765AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359784, RefRangeEnd = 359785, XrefRangeStart = 359783, XrefRangeEnd = 359784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(Hashtable table)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005521 RID: 21793 RVA: 0x001783F8 File Offset: 0x001765F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359785, XrefRangeEnd = 359797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005522 RID: 21794 RVA: 0x0017845C File Offset: 0x0017665C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359797, XrefRangeEnd = 359809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015CE RID: 5582
			// (get) Token: 0x06005523 RID: 21795 RVA: 0x001784C0 File Offset: 0x001766C0
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359809, XrefRangeEnd = 359810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170015CF RID: 5583
			public unsafe override Object this[Object key]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359810, XrefRangeEnd = 359811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359811, XrefRangeEnd = 359814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015D0 RID: 5584
			// (get) Token: 0x06005526 RID: 21798 RVA: 0x001785C4 File Offset: 0x001767C4
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359814, XrefRangeEnd = 359815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005527 RID: 21799 RVA: 0x00178610 File Offset: 0x00176810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359815, XrefRangeEnd = 359818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Add(Object key, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005528 RID: 21800 RVA: 0x00178670 File Offset: 0x00176870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359818, XrefRangeEnd = 359821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005529 RID: 21801 RVA: 0x001786AC File Offset: 0x001768AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359821, XrefRangeEnd = 359822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600552A RID: 21802 RVA: 0x00178704 File Offset: 0x00176904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359822, XrefRangeEnd = 359831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600552B RID: 21803 RVA: 0x0017875C File Offset: 0x0017695C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359831, XrefRangeEnd = 359834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600552C RID: 21804 RVA: 0x001787B8 File Offset: 0x001769B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359834, XrefRangeEnd = 359841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600552D RID: 21805 RVA: 0x00178804 File Offset: 0x00176A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359841, XrefRangeEnd = 359842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600552E RID: 21806 RVA: 0x00178844 File Offset: 0x00176A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionaryEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
			}

			// Token: 0x170015D1 RID: 5585
			// (get) Token: 0x0600552F RID: 21807 RVA: 0x00178890 File Offset: 0x00176A90
			public unsafe override ICollection Keys
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359842, XrefRangeEnd = 359845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x170015D2 RID: 5586
			// (get) Token: 0x06005530 RID: 21808 RVA: 0x001788DC File Offset: 0x00176ADC
			public unsafe override ICollection Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359845, XrefRangeEnd = 359848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x06005531 RID: 21809 RVA: 0x00178928 File Offset: 0x00176B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359848, XrefRangeEnd = 359851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x00178978 File Offset: 0x00176B78
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005533 RID: 21811 RVA: 0x00020D7C File Offset: 0x0001EF7C
			public SyncHashtable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CD RID: 5581
			// (get) Token: 0x06005534 RID: 21812 RVA: 0x001789C8 File Offset: 0x00176BC8
			// (set) Token: 0x06005535 RID: 21813 RVA: 0x00020D85 File Offset: 0x0001EF85
			public unsafe Hashtable _table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004467 RID: 17511
			private static readonly IntPtr NativeFieldInfoPtr__table;

			// Token: 0x04004468 RID: 17512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x04004469 RID: 17513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400446A RID: 17514
			private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400446B RID: 17515
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x0400446C RID: 17516
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0;

			// Token: 0x0400446D RID: 17517
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0;

			// Token: 0x0400446E RID: 17518
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x0400446F RID: 17519
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0;

			// Token: 0x04004470 RID: 17520
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04004471 RID: 17521
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004472 RID: 17522
			private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004473 RID: 17523
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x04004474 RID: 17524
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x04004475 RID: 17525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004476 RID: 17526
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

			// Token: 0x04004477 RID: 17527
			private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0;

			// Token: 0x04004478 RID: 17528
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0;

			// Token: 0x04004479 RID: 17529
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x0400447A RID: 17530
			private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;
		}

		// Token: 0x02000651 RID: 1617
		[Serializable]
		public class HashtableEnumerator : Object
		{
			// Token: 0x06005536 RID: 21814 RVA: 0x001789F8 File Offset: 0x00176BF8
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableEnumerator()
			{
				Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr);
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "hashtable");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "bucket");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "version");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "current");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "getObjectRetType");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "currentKey");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "currentValue");
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673269);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673270);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673271);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673272);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673273);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673274);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673275);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673276);
			}

			// Token: 0x06005537 RID: 21815 RVA: 0x00178B50 File Offset: 0x00176D50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359853, RefRangeEnd = 359855, XrefRangeStart = 359851, XrefRangeEnd = 359853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashtableEnumerator(Hashtable hashtable, int getObjRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getObjRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005538 RID: 21816 RVA: 0x00178BAC File Offset: 0x00176DAC
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x170015DA RID: 5594
			// (get) Token: 0x06005539 RID: 21817 RVA: 0x00178BEC File Offset: 0x00176DEC
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600553A RID: 21818 RVA: 0x00178C38 File Offset: 0x00176E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359855, XrefRangeEnd = 359856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015DB RID: 5595
			// (get) Token: 0x0600553B RID: 21819 RVA: 0x00178C80 File Offset: 0x00176E80
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359856, XrefRangeEnd = 359857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170015DC RID: 5596
			// (get) Token: 0x0600553C RID: 21820 RVA: 0x00178CC4 File Offset: 0x00176EC4
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359857, XrefRangeEnd = 359861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015DD RID: 5597
			// (get) Token: 0x0600553D RID: 21821 RVA: 0x00178D10 File Offset: 0x00176F10
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600553E RID: 21822 RVA: 0x00178D5C File Offset: 0x00176F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359861, XrefRangeEnd = 359862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600553F RID: 21823 RVA: 0x00020DA4 File Offset: 0x0001EFA4
			public HashtableEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D3 RID: 5587
			// (get) Token: 0x06005540 RID: 21824 RVA: 0x00178D98 File Offset: 0x00176F98
			// (set) Token: 0x06005541 RID: 21825 RVA: 0x00020DAD File Offset: 0x0001EFAD
			public unsafe Hashtable hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D4 RID: 5588
			// (get) Token: 0x06005542 RID: 21826 RVA: 0x00178DC8 File Offset: 0x00176FC8
			// (set) Token: 0x06005543 RID: 21827 RVA: 0x00020DCC File Offset: 0x0001EFCC
			public unsafe int bucket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket)) = value;
				}
			}

			// Token: 0x170015D5 RID: 5589
			// (get) Token: 0x06005544 RID: 21828 RVA: 0x00178DF0 File Offset: 0x00176FF0
			// (set) Token: 0x06005545 RID: 21829 RVA: 0x00020DE7 File Offset: 0x0001EFE7
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170015D6 RID: 5590
			// (get) Token: 0x06005546 RID: 21830 RVA: 0x00178E18 File Offset: 0x00177018
			// (set) Token: 0x06005547 RID: 21831 RVA: 0x00020E02 File Offset: 0x0001F002
			public unsafe bool current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current)) = value;
				}
			}

			// Token: 0x170015D7 RID: 5591
			// (get) Token: 0x06005548 RID: 21832 RVA: 0x00178E40 File Offset: 0x00177040
			// (set) Token: 0x06005549 RID: 21833 RVA: 0x00020E1D File Offset: 0x0001F01D
			public unsafe int getObjectRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType)) = value;
				}
			}

			// Token: 0x170015D8 RID: 5592
			// (get) Token: 0x0600554A RID: 21834 RVA: 0x00178E68 File Offset: 0x00177068
			// (set) Token: 0x0600554B RID: 21835 RVA: 0x00020E38 File Offset: 0x0001F038
			public unsafe Object currentKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D9 RID: 5593
			// (get) Token: 0x0600554C RID: 21836 RVA: 0x00178E98 File Offset: 0x00177098
			// (set) Token: 0x0600554D RID: 21837 RVA: 0x00020E57 File Offset: 0x0001F057
			public unsafe Object currentValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400447B RID: 17531
			private static readonly IntPtr NativeFieldInfoPtr_hashtable;

			// Token: 0x0400447C RID: 17532
			private static readonly IntPtr NativeFieldInfoPtr_bucket;

			// Token: 0x0400447D RID: 17533
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x0400447E RID: 17534
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400447F RID: 17535
			private static readonly IntPtr NativeFieldInfoPtr_getObjectRetType;

			// Token: 0x04004480 RID: 17536
			private static readonly IntPtr NativeFieldInfoPtr_currentKey;

			// Token: 0x04004481 RID: 17537
			private static readonly IntPtr NativeFieldInfoPtr_currentValue;

			// Token: 0x04004482 RID: 17538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0;

			// Token: 0x04004483 RID: 17539
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004484 RID: 17540
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0;

			// Token: 0x04004485 RID: 17541
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004486 RID: 17542
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0;

			// Token: 0x04004487 RID: 17543
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004488 RID: 17544
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

			// Token: 0x04004489 RID: 17545
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000652 RID: 1618
		public class HashtableDebugView : Object
		{
			// Token: 0x0600554E RID: 21838 RVA: 0x00020E76 File Offset: 0x0001F076
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableDebugView()
			{
				Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr);
			}

			// Token: 0x0600554F RID: 21839 RVA: 0x00020E96 File Offset: 0x0001F096
			public HashtableDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
