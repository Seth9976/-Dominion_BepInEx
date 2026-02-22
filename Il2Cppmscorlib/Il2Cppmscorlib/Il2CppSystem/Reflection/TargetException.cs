using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B9 RID: 441
	[Serializable]
	public class TargetException : ApplicationException
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x000A1100 File Offset: 0x0009F300
		// Note: this type is marked as 'beforefieldinit'.
		static TargetException()
		{
			Il2CppClassPointerStore<TargetException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TargetException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetException>.NativeClassPtr);
			TargetException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetException>.NativeClassPtr, 100668011);
			TargetException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetException>.NativeClassPtr, 100668012);
			TargetException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetException>.NativeClassPtr, 100668013);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000A116C File Offset: 0x0009F36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317331, XrefRangeEnd = 317333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000A11A8 File Offset: 0x0009F3A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317335, RefRangeEnd = 317339, XrefRangeStart = 317333, XrefRangeEnd = 317335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000A11F4 File Offset: 0x0009F3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00009BF2 File Offset: 0x00007DF2
		public TargetException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
