using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class AggregateException : Exception
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x0003E60C File Offset: 0x0003C80C
		// Note: this type is marked as 'beforefieldinit'.
		static AggregateException()
		{
			Il2CppClassPointerStore<AggregateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AggregateException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggregateException>.NativeClassPtr);
			AggregateException.NativeFieldInfoPtr_m_innerExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, "m_innerExceptions");
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664304);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664305);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664306);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664307);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664308);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664309);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664310);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664311);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664312);
			AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664313);
			AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664314);
			AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664315);
			AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664316);
			AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664317);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0003E768 File Offset: 0x0003C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275040, XrefRangeEnd = 275056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0003E7A4 File Offset: 0x0003C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275056, XrefRangeEnd = 275071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275075, RefRangeEnd = 275077, XrefRangeStart = 275071, XrefRangeEnd = 275075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException([Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0003E848 File Offset: 0x0003CA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275077, XrefRangeEnd = 275089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275089, XrefRangeEnd = 275090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, [Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0003E914 File Offset: 0x0003CB14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 275116, RefRangeEnd = 275121, XrefRangeStart = 275090, XrefRangeEnd = 275116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0003E974 File Offset: 0x0003CB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275136, RefRangeEnd = 275137, XrefRangeStart = 275121, XrefRangeEnd = 275136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275149, RefRangeEnd = 275150, XrefRangeStart = 275137, XrefRangeEnd = 275149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0003EA20 File Offset: 0x0003CC20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275179, RefRangeEnd = 275181, XrefRangeStart = 275150, XrefRangeEnd = 275179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0003EA80 File Offset: 0x0003CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275181, XrefRangeEnd = 275203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275203, XrefRangeEnd = 275222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0003EB48 File Offset: 0x0003CD48
		public unsafe ReadOnlyCollection<Exception> InnerExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr3) : null;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0003EB88 File Offset: 0x0003CD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275258, RefRangeEnd = 275260, XrefRangeStart = 275222, XrefRangeEnd = 275258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException Flatten()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275260, XrefRangeEnd = 275293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00003FBC File Offset: 0x000021BC
		public AggregateException(params Exception[] innerExceptions)
			: this(new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00003FCA File Offset: 0x000021CA
		public AggregateException(string message, params Exception[] innerExceptions)
			: this(message, new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00003FD9 File Offset: 0x000021D9
		public AggregateException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0003EC0C File Offset: 0x0003CE0C
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00003FE2 File Offset: 0x000021E2
		public unsafe ReadOnlyCollection<Exception> m_innerExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_m_innerExceptions;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_Flatten_Public_AggregateException_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
