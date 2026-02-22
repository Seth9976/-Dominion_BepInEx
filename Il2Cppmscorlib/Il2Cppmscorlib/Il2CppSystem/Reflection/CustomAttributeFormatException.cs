using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class CustomAttributeFormatException : FormatException
	{
		// Token: 0x06001D0F RID: 7439 RVA: 0x000A482C File Offset: 0x000A2A2C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeFormatException()
		{
			Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeFormatException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr);
			CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr, 100668134);
			CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr, 100668135);
			CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr, 100668136);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000A4898 File Offset: 0x000A2A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318115, XrefRangeEnd = 318119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeFormatException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000A48D4 File Offset: 0x000A2AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36366, RefRangeEnd = 36367, XrefRangeStart = 36366, XrefRangeEnd = 36367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeFormatException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000A4920 File Offset: 0x000A2B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeFormatException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeFormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000A004 File Offset: 0x00008204
		public CustomAttributeFormatException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
