using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BB RID: 443
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x000A1424 File Offset: 0x0009F624
		// Note: this type is marked as 'beforefieldinit'.
		static TargetParameterCountException()
		{
			Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TargetParameterCountException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668018);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668019);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100668020);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000A1490 File Offset: 0x0009F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317351, XrefRangeEnd = 317356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000A14CC File Offset: 0x0009F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317356, XrefRangeEnd = 317358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000A1518 File Offset: 0x0009F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00009C04 File Offset: 0x00007E04
		public TargetParameterCountException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
