using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000188 RID: 392
	public sealed class RuntimeResourceSet : ResourceSet
	{
		// Token: 0x06001B39 RID: 6969 RVA: 0x0009CF08 File Offset: 0x0009B108
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeResourceSet()
		{
			Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "RuntimeResourceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr);
			RuntimeResourceSet.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "Version");
			RuntimeResourceSet.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_resCache");
			RuntimeResourceSet.NativeFieldInfoPtr__defaultReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_defaultReader");
			RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_caseInsensitiveTable");
			RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_haveReadFromReader");
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667880);
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667881);
			RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667882);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667883);
			RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667884);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667885);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667886);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667887);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667888);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667889);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667890);
			RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667891);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0009D08C File Offset: 0x0009B28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316676, RefRangeEnd = 316677, XrefRangeStart = 316657, XrefRangeEnd = 316676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0009D0D8 File Offset: 0x0009B2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316692, RefRangeEnd = 316693, XrefRangeStart = 316677, XrefRangeEnd = 316692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0009D124 File Offset: 0x0009B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316693, XrefRangeEnd = 316699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0009D164 File Offset: 0x0009B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316699, XrefRangeEnd = 316700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0009D1A4 File Offset: 0x0009B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0009D1E4 File Offset: 0x0009B3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316710, RefRangeEnd = 316712, XrefRangeStart = 316700, XrefRangeEnd = 316710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IDictionaryEnumerator GetEnumeratorHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0009D224 File Offset: 0x0009B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316712, XrefRangeEnd = 316715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0009D26C File Offset: 0x0009B46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316715, XrefRangeEnd = 316718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0009D2C4 File Offset: 0x0009B4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316718, XrefRangeEnd = 316719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0009D314 File Offset: 0x0009B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316719, XrefRangeEnd = 316720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0009D374 File Offset: 0x0009B574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316789, RefRangeEnd = 316793, XrefRangeStart = 316720, XrefRangeEnd = 316789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetObject(string key, bool ignoreCase, bool isString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0009D3E0 File Offset: 0x0009B5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316801, RefRangeEnd = 316803, XrefRangeStart = 316793, XrefRangeEnd = 316801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resLocation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyOfCache);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyInWrongCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x000095FE File Offset: 0x000077FE
		public RuntimeResourceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0009D468 File Offset: 0x0009B668
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00009607 File Offset: 0x00007807
		public unsafe static int Version
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x0009D484 File Offset: 0x0009B684
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00009615 File Offset: 0x00007815
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0009D4B4 File Offset: 0x0009B6B4
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00009634 File Offset: 0x00007834
		public unsafe ResourceReader _defaultReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x0009D4E4 File Offset: 0x0009B6E4
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00009653 File Offset: 0x00007853
		public new unsafe Dictionary<string, ResourceLocator> _caseInsensitiveTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0009D514 File Offset: 0x0009B714
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00009672 File Offset: 0x00007872
		public unsafe bool _haveReadFromReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader)) = value;
			}
		}

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeFieldInfoPtr__defaultReader;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitiveTable;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeFieldInfoPtr__haveReadFromReader;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0;
	}
}
