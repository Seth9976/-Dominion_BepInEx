using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.AndroidNative.DynamicLinks
{
	// Token: 0x0200034D RID: 845
	public static class Proxy : Object
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x000D4EC8 File Offset: 0x000D30C8
		// Note: this type is marked as 'beforefieldinit'.
		static Proxy()
		{
			Il2CppClassPointerStore<Proxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.DynamicLinks", "Proxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Proxy>.NativeClassPtr);
			Proxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Proxy>.NativeClassPtr, "CLASS_NAME");
			Proxy.NativeMethodInfoPtr_GetPendingLink_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669845);
			Proxy.NativeMethodInfoPtr_RequestLink_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669846);
			Proxy.NativeMethodInfoPtr_CallStaticFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Proxy>.NativeClassPtr, 100669847);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000D4F48 File Offset: 0x000D3148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223223, XrefRangeEnd = 223225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPendingLink()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_GetPendingLink_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000D4F74 File Offset: 0x000D3174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223239, RefRangeEnd = 223240, XrefRangeStart = 223225, XrefRangeEnd = 223239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestLink(string request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Proxy.NativeMethodInfoPtr_RequestLink_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000D4FAC File Offset: 0x000D31AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223240, XrefRangeEnd = 223243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003312 RID: 13074 RVA: 0x00013D62 File Offset: 0x00011F62
		public static void CallStaticFunction(string methodName, params Object[] args)
		{
			Proxy.CallStaticFunction(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00013D70 File Offset: 0x00011F70
		public Proxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x000D5004 File Offset: 0x000D3204
		// (set) Token: 0x06003315 RID: 13077 RVA: 0x00013D79 File Offset: 0x00011F79
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

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_GetPendingLink_Public_Static_String_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_RequestLink_Public_Static_Void_String_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;
	}
}
