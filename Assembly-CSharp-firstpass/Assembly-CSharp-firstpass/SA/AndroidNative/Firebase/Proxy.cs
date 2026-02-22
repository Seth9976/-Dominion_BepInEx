using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.AndroidNative.Firebase
{
	// Token: 0x02000353 RID: 851
	public static class Proxy : Object
	{
		// Token: 0x06003353 RID: 13139 RVA: 0x000D5C28 File Offset: 0x000D3E28
		// Note: this type is marked as 'beforefieldinit'.
		static Proxy()
		{
			Il2CppClassPointerStore<Proxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.Firebase", "Proxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Proxy>.NativeClassPtr);
			Proxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Proxy>.NativeClassPtr, "CLASS_NAME");
			Proxy.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669873);
			Proxy.NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669874);
			Proxy.NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669875);
			Proxy.NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669876);
			Proxy.NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669877);
			Proxy.NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669878);
			Proxy.NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669879);
			Proxy.NativeMethodInfoPtr_CallStaticFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669880);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000D5D0C File Offset: 0x000D3F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223646, RefRangeEnd = 223647, XrefRangeStart = 223638, XrefRangeEnd = 223646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000D5D34 File Offset: 0x000D3F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223659, RefRangeEnd = 223660, XrefRangeStart = 223647, XrefRangeEnd = 223659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEnabled(bool enabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000D5D68 File Offset: 0x000D3F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223672, RefRangeEnd = 223673, XrefRangeStart = 223660, XrefRangeEnd = 223672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMinimumSessionDuration(long milliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000D5D9C File Offset: 0x000D3F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223685, RefRangeEnd = 223686, XrefRangeStart = 223673, XrefRangeEnd = 223685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSessionTimeoutDuration(long milliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000D5DD0 File Offset: 0x000D3FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223700, RefRangeEnd = 223701, XrefRangeStart = 223686, XrefRangeEnd = 223700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserId(string userId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000D5E08 File Offset: 0x000D4008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223720, RefRangeEnd = 223721, XrefRangeStart = 223701, XrefRangeEnd = 223720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserProperty(string name, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000D5E50 File Offset: 0x000D4050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223740, RefRangeEnd = 223741, XrefRangeStart = 223721, XrefRangeEnd = 223740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogEvent(string name, string data = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000D5E98 File Offset: 0x000D4098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223741, XrefRangeEnd = 223744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallStaticFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_CallStaticFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00013F31 File Offset: 0x00012131
		public static void CallStaticFunction(string methodName, params Object[] args)
		{
			Proxy.CallStaticFunction(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00013F3F File Offset: 0x0001213F
		public Proxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x000D5EF0 File Offset: 0x000D40F0
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00013F48 File Offset: 0x00012148
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

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_String_0;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;
	}
}
