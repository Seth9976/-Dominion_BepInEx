using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

namespace SA.Fitness
{
	// Token: 0x02000329 RID: 809
	public sealed class History : Singleton<History>
	{
		// Token: 0x06002FA8 RID: 12200 RVA: 0x000CB688 File Offset: 0x000C9888
		// Note: this type is marked as 'beforefieldinit'.
		static History()
		{
			Il2CppClassPointerStore<History>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "History");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<History>.NativeClassPtr);
			History.NativeFieldInfoPtr_dailyTotalRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<History>.NativeClassPtr, "dailyTotalRequests");
			History.NativeFieldInfoPtr_readRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<History>.NativeClassPtr, "readRequests");
			History.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669606);
			History.NativeMethodInfoPtr_ReadData_Public_Void_ReadHistoryRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669607);
			History.NativeMethodInfoPtr_ReadDailyTotal_Public_Void_ReadDailyTotalRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669608);
			History.NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Void_ReadDailyTotalRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669609);
			History.NativeMethodInfoPtr_InsertData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669610);
			History.NativeMethodInfoPtr_UpdateData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669611);
			History.NativeMethodInfoPtr_DeleteData_Public_Void_DeleteDataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669612);
			History.NativeMethodInfoPtr_DispatchReadDailyTotalRequest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669613);
			History.NativeMethodInfoPtr_DispatchReadHistoryRequest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669614);
			History.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100669615);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000CB7A8 File Offset: 0x000C99A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220657, XrefRangeEnd = 220662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000CB7DC File Offset: 0x000C99DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220716, RefRangeEnd = 220717, XrefRangeStart = 220662, XrefRangeEnd = 220716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadData(ReadHistoryRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_ReadData_Public_Void_ReadHistoryRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000CB820 File Offset: 0x000C9A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220731, RefRangeEnd = 220732, XrefRangeStart = 220717, XrefRangeEnd = 220731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadDailyTotal(ReadDailyTotalRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_ReadDailyTotal_Public_Void_ReadDailyTotalRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000CB864 File Offset: 0x000C9A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220732, XrefRangeEnd = 220746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadDailyTotalFromLocalDevice(ReadDailyTotalRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Void_ReadDailyTotalRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x000CB8A8 File Offset: 0x000C9AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220754, RefRangeEnd = 220755, XrefRangeStart = 220746, XrefRangeEnd = 220754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_InsertData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220763, RefRangeEnd = 220764, XrefRangeStart = 220755, XrefRangeEnd = 220763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_UpdateData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000CB910 File Offset: 0x000C9B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220772, RefRangeEnd = 220773, XrefRangeStart = 220764, XrefRangeEnd = 220772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteData(DeleteDataRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_DeleteData_Public_Void_DeleteDataRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x000CB954 File Offset: 0x000C9B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220773, XrefRangeEnd = 220796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchReadDailyTotalRequest(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_DispatchReadDailyTotalRequest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000CB998 File Offset: 0x000C9B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220796, XrefRangeEnd = 220825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchReadHistoryRequest(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr_DispatchReadHistoryRequest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000CB9DC File Offset: 0x000C9BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220825, XrefRangeEnd = 220843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe History()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<History>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00012319 File Offset: 0x00010519
		public History(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000CBA18 File Offset: 0x000C9C18
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00012322 File Offset: 0x00010522
		public unsafe Dictionary<int, ReadDailyTotalRequest> dailyTotalRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(History.NativeFieldInfoPtr_dailyTotalRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ReadDailyTotalRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(History.NativeFieldInfoPtr_dailyTotalRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002FB6 RID: 12214 RVA: 0x000CBA48 File Offset: 0x000C9C48
		// (set) Token: 0x06002FB7 RID: 12215 RVA: 0x00012341 File Offset: 0x00010541
		public unsafe Dictionary<int, ReadHistoryRequest> readRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(History.NativeFieldInfoPtr_readRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ReadHistoryRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(History.NativeFieldInfoPtr_readRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeFieldInfoPtr_dailyTotalRequests;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeFieldInfoPtr_readRequests;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Public_Void_ReadHistoryRequest_0;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeMethodInfoPtr_ReadDailyTotal_Public_Void_ReadDailyTotalRequest_0;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Void_ReadDailyTotalRequest_0;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeMethodInfoPtr_InsertData_Public_Void_0;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Void_0;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeMethodInfoPtr_DeleteData_Public_Void_DeleteDataRequest_0;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeMethodInfoPtr_DispatchReadDailyTotalRequest_Private_Void_String_0;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr_DispatchReadHistoryRequest_Private_Void_String_0;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
