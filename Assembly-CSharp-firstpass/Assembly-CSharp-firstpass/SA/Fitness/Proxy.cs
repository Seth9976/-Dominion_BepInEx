using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x0200034C RID: 844
	public static class Proxy : Object
	{
		// Token: 0x060032F7 RID: 13047 RVA: 0x000D48FC File Offset: 0x000D2AFC
		// Note: this type is marked as 'beforefieldinit'.
		static Proxy()
		{
			Il2CppClassPointerStore<Proxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Proxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Proxy>.NativeClassPtr);
			Proxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Proxy>.NativeClassPtr, "CLASS_NAME");
			Proxy.NativeMethodInfoPtr_Call_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669827);
			Proxy.NativeMethodInfoPtr_Connect_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669828);
			Proxy.NativeMethodInfoPtr_Disconnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669829);
			Proxy.NativeMethodInfoPtr_RequestDataSources_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669830);
			Proxy.NativeMethodInfoPtr_RegisterSensorListener_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669831);
			Proxy.NativeMethodInfoPtr_ListSubscriptions_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669832);
			Proxy.NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669833);
			Proxy.NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669834);
			Proxy.NativeMethodInfoPtr_ReadData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669835);
			Proxy.NativeMethodInfoPtr_ReadDailyTotal_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669836);
			Proxy.NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669837);
			Proxy.NativeMethodInfoPtr_InsertData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669838);
			Proxy.NativeMethodInfoPtr_UpdateData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669839);
			Proxy.NativeMethodInfoPtr_DeleteData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669840);
			Proxy.NativeMethodInfoPtr_StartSession_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669841);
			Proxy.NativeMethodInfoPtr_StopSession_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669842);
			Proxy.NativeMethodInfoPtr_ReadSession_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669843);
			Proxy.NativeMethodInfoPtr_InsertSesison_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669844);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000D4AA8 File Offset: 0x000D2CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222974, XrefRangeEnd = 222977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Call(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Call_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000D4B00 File Offset: 0x000D2D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222991, RefRangeEnd = 222992, XrefRangeStart = 222977, XrefRangeEnd = 222991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect(string connectionRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(connectionRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Connect_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000D4B38 File Offset: 0x000D2D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223000, RefRangeEnd = 223002, XrefRangeStart = 222992, XrefRangeEnd = 223000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Disconnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000D4B60 File Offset: 0x000D2D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223016, RefRangeEnd = 223017, XrefRangeStart = 223002, XrefRangeEnd = 223016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestDataSources(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_RequestDataSources_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000D4B98 File Offset: 0x000D2D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223031, RefRangeEnd = 223032, XrefRangeStart = 223017, XrefRangeEnd = 223031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterSensorListener(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_RegisterSensorListener_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000D4BD0 File Offset: 0x000D2DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223032, XrefRangeEnd = 223046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ListSubscriptions(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_ListSubscriptions_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000D4C08 File Offset: 0x000D2E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223046, XrefRangeEnd = 223060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Subscribe(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000D4C40 File Offset: 0x000D2E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223060, XrefRangeEnd = 223074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unsubscribe(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000D4C78 File Offset: 0x000D2E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223088, RefRangeEnd = 223089, XrefRangeStart = 223074, XrefRangeEnd = 223088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadData(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_ReadData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000D4CB0 File Offset: 0x000D2EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223103, RefRangeEnd = 223104, XrefRangeStart = 223089, XrefRangeEnd = 223103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadDailyTotal(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_ReadDailyTotal_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000D4CE8 File Offset: 0x000D2EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223118, RefRangeEnd = 223119, XrefRangeStart = 223104, XrefRangeEnd = 223118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadDailyTotalFromLocalDevice(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000D4D20 File Offset: 0x000D2F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223133, RefRangeEnd = 223134, XrefRangeStart = 223119, XrefRangeEnd = 223133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertData(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_InsertData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000D4D58 File Offset: 0x000D2F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223148, RefRangeEnd = 223149, XrefRangeStart = 223134, XrefRangeEnd = 223148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateData(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_UpdateData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000D4D90 File Offset: 0x000D2F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223163, RefRangeEnd = 223164, XrefRangeStart = 223149, XrefRangeEnd = 223163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteData(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_DeleteData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000D4DC8 File Offset: 0x000D2FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223178, RefRangeEnd = 223179, XrefRangeStart = 223164, XrefRangeEnd = 223178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartSession(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_StartSession_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000D4E00 File Offset: 0x000D3000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223193, RefRangeEnd = 223194, XrefRangeStart = 223179, XrefRangeEnd = 223193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopSession(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_StopSession_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000D4E38 File Offset: 0x000D3038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223208, RefRangeEnd = 223209, XrefRangeStart = 223194, XrefRangeEnd = 223208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadSession(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_ReadSession_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000D4E70 File Offset: 0x000D3070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223209, XrefRangeEnd = 223223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertSesison(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_InsertSesison_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00013D39 File Offset: 0x00011F39
		public static void Call(string methodName, params Object[] args)
		{
			Proxy.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00013D47 File Offset: 0x00011F47
		public Proxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x000D4EA8 File Offset: 0x000D30A8
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x00013D50 File Offset: 0x00011F50
		public unsafe static string CLASS_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Proxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Proxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeMethodInfoPtr_Call_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Void_String_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Static_Void_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr_RequestDataSources_Public_Static_Void_String_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSensorListener_Public_Static_Void_String_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_ListSubscriptions_Public_Static_Void_String_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_String_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Public_Static_Void_String_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_ReadDailyTotal_Public_Static_Void_String_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_ReadDailyTotalFromLocalDevice_Public_Static_Void_String_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_InsertData_Public_Static_Void_String_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Static_Void_String_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_DeleteData_Public_Static_Void_String_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_StartSession_Public_Static_Void_String_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_StopSession_Public_Static_Void_String_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_ReadSession_Public_Static_Void_String_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_InsertSesison_Public_Static_Void_String_0;
	}
}
