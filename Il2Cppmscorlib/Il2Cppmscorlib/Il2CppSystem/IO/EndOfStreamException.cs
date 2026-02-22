using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x0600207A RID: 8314 RVA: 0x000B4740 File Offset: 0x000B2940
		// Note: this type is marked as 'beforefieldinit'.
		static EndOfStreamException()
		{
			Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "EndOfStreamException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668702);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668703);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668704);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000B47AC File Offset: 0x000B29AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320497, XrefRangeEnd = 320501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000B47E8 File Offset: 0x000B29E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320503, RefRangeEnd = 320504, XrefRangeStart = 320501, XrefRangeEnd = 320503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000B4834 File Offset: 0x000B2A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0000AF8F File Offset: 0x0000918F
		public EndOfStreamException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
