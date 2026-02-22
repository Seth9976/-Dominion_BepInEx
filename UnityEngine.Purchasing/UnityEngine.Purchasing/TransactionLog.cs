using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000019 RID: 25
	public class TransactionLog : Object
	{
		// Token: 0x06000100 RID: 256 RVA: 0x000067EC File Offset: 0x000049EC
		// Note: this type is marked as 'beforefieldinit'.
		static TransactionLog()
		{
			Il2CppClassPointerStore<TransactionLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "TransactionLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr);
			TransactionLog.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, "logger");
			TransactionLog.NativeFieldInfoPtr_persistentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, "persistentDataPath");
			TransactionLog.NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, 100663428);
			TransactionLog.NativeMethodInfoPtr_HasRecordOf_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, 100663429);
			TransactionLog.NativeMethodInfoPtr_Record_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, 100663430);
			TransactionLog.NativeMethodInfoPtr_GetRecordPath_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, 100663431);
			TransactionLog.NativeMethodInfoPtr_ComputeHash_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr, 100663432);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000068A8 File Offset: 0x00004AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131110, XrefRangeEnd = 131121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransactionLog(ILogger logger, string persistentDataPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransactionLog>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(persistentDataPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransactionLog.NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006908 File Offset: 0x00004B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131121, XrefRangeEnd = 131125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasRecordOf(string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransactionLog.NativeMethodInfoPtr_HasRecordOf_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006958 File Offset: 0x00004B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131132, RefRangeEnd = 131133, XrefRangeStart = 131125, XrefRangeEnd = 131132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Record(string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransactionLog.NativeMethodInfoPtr_Record_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000699C File Offset: 0x00004B9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131158, RefRangeEnd = 131161, XrefRangeStart = 131133, XrefRangeEnd = 131158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRecordPath(string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransactionLog.NativeMethodInfoPtr_GetRecordPath_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000069E4 File Offset: 0x00004BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131161, XrefRangeEnd = 131182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ComputeHash(string transactionID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransactionLog.NativeMethodInfoPtr_ComputeHash_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000026E7 File Offset: 0x000008E7
		public TransactionLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006A20 File Offset: 0x00004C20
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000026F0 File Offset: 0x000008F0
		public unsafe ILogger logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransactionLog.NativeFieldInfoPtr_logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransactionLog.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000270F File Offset: 0x0000090F
		public unsafe string persistentDataPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransactionLog.NativeFieldInfoPtr_persistentDataPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransactionLog.NativeFieldInfoPtr_persistentDataPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_persistentDataPath;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogger_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_HasRecordOf_Public_Boolean_String_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Record_Public_Void_String_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_GetRecordPath_Private_String_String_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Internal_Static_String_String_0;
	}
}
