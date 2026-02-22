using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000186 RID: 390
	[Serializable]
	public class ResourceSet : Object
	{
		// Token: 0x06001B23 RID: 6947 RVA: 0x0009C8D0 File Offset: 0x0009AAD0
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceSet()
		{
			Il2CppClassPointerStore<ResourceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr);
			ResourceSet.NativeFieldInfoPtr_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "Reader");
			ResourceSet.NativeFieldInfoPtr_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "Table");
			ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "_caseInsensitiveTable");
			ResourceSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667866);
			ResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667867);
			ResourceSet.NativeMethodInfoPtr_CommonInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667868);
			ResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667869);
			ResourceSet.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667870);
			ResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667871);
			ResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667872);
			ResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667873);
			ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667874);
			ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667875);
			ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667876);
			ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667877);
			ResourceSet.NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667878);
			ResourceSet.NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100667879);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0009CA54 File Offset: 0x0009AC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316569, XrefRangeEnd = 316574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0009CA90 File Offset: 0x0009AC90
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet(bool junk)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref junk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0009CAD8 File Offset: 0x0009ACD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316574, XrefRangeEnd = 316578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_CommonInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0009CB0C File Offset: 0x0009AD0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316581, RefRangeEnd = 316583, XrefRangeStart = 316578, XrefRangeEnd = 316581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0009CB58 File Offset: 0x0009AD58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316583, RefRangeEnd = 316593, XrefRangeStart = 316583, XrefRangeEnd = 316583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0009CB8C File Offset: 0x0009AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316593, XrefRangeEnd = 316594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0009CBD8 File Offset: 0x0009ADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0009CC18 File Offset: 0x0009AE18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316601, RefRangeEnd = 316603, XrefRangeStart = 316594, XrefRangeEnd = 316601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumeratorHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0009CC58 File Offset: 0x0009AE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316603, XrefRangeEnd = 316605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0009CCAC File Offset: 0x0009AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316605, XrefRangeEnd = 316609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0009CD10 File Offset: 0x0009AF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316609, XrefRangeEnd = 316622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetObject(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0009CD6C File Offset: 0x0009AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316622, XrefRangeEnd = 316623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetObject(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0009CDD8 File Offset: 0x0009AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetObjectInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0009CE28 File Offset: 0x0009B028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316655, RefRangeEnd = 316657, XrefRangeStart = 316623, XrefRangeEnd = 316655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetCaseInsensitiveObjectInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00009598 File Offset: 0x00007798
		public ResourceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0009CE78 File Offset: 0x0009B078
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x000095A1 File Offset: 0x000077A1
		public unsafe IResourceReader Reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0009CEA8 File Offset: 0x0009B0A8
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x000095C0 File Offset: 0x000077C0
		public unsafe Hashtable Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0009CED8 File Offset: 0x0009B0D8
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x000095DF File Offset: 0x000077DF
		public unsafe Hashtable _caseInsensitiveTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeFieldInfoPtr_Reader;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeFieldInfoPtr_Table;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitiveTable;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_CommonInit_Private_Void_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0;
	}
}
