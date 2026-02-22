using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00041D04 File Offset: 0x0003FF04
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentNullException()
		{
			Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentNullException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664397);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664398);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664399);
			ArgumentNullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr, 100664400);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00041D84 File Offset: 0x0003FF84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275790, RefRangeEnd = 275793, XrefRangeStart = 275784, XrefRangeEnd = 275790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		[CallerCount(212)]
		[CachedScanResults(RefRangeStart = 275799, RefRangeEnd = 276011, XrefRangeStart = 275793, XrefRangeEnd = 275799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00041E0C File Offset: 0x0004000C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 276014, RefRangeEnd = 276034, XrefRangeStart = 276011, XrefRangeEnd = 276014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00041E6C File Offset: 0x0004006C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275765, RefRangeEnd = 275768, XrefRangeStart = 275765, XrefRangeEnd = 275768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentNullException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentNullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentNullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000044BC File Offset: 0x000026BC
		public ArgumentNullException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
