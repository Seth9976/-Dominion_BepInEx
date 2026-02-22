using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040E RID: 1038
	public sealed class ExceptionDispatchInfo : Object
	{
		// Token: 0x06004164 RID: 16740 RVA: 0x0012E3FC File Offset: 0x0012C5FC
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionDispatchInfo()
		{
			Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "ExceptionDispatchInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr);
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_Exception");
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_stackTrace");
			ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100672817);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100672818);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100672819);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100672820);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100672821);
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0012E4B8 File Offset: 0x0012C6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356003, XrefRangeEnd = 356015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo(Exception exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x0012E504 File Offset: 0x0012C704
		public unsafe Object BinaryStackTraceArray
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0012E544 File Offset: 0x0012C744
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 356030, RefRangeEnd = 356044, XrefRangeStart = 356015, XrefRangeEnd = 356030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExceptionDispatchInfo Capture(Exception source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x0012E588 File Offset: 0x0012C788
		public unsafe Exception SourceException
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x0012E5C8 File Offset: 0x0012C7C8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 356050, RefRangeEnd = 356073, XrefRangeStart = 356044, XrefRangeEnd = 356050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00018DF4 File Offset: 0x00016FF4
		public ExceptionDispatchInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x0012E5FC File Offset: 0x0012C7FC
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x00018DFD File Offset: 0x00016FFD
		public unsafe Exception m_Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x0012E62C File Offset: 0x0012C82C
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00018E1C File Offset: 0x0001701C
		public unsafe Object m_stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003561 RID: 13665
		private static readonly IntPtr NativeFieldInfoPtr_m_Exception;

		// Token: 0x04003562 RID: 13666
		private static readonly IntPtr NativeFieldInfoPtr_m_stackTrace;

		// Token: 0x04003563 RID: 13667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Exception_0;

		// Token: 0x04003564 RID: 13668
		private static readonly IntPtr NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0;

		// Token: 0x04003565 RID: 13669
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0;

		// Token: 0x04003566 RID: 13670
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0;

		// Token: 0x04003567 RID: 13671
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;
	}
}
