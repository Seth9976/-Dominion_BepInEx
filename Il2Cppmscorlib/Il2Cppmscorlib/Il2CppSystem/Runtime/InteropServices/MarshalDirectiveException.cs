using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000455 RID: 1109
	[Serializable]
	public class MarshalDirectiveException : SystemException
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x00133608 File Offset: 0x00131808
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalDirectiveException()
		{
			Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MarshalDirectiveException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr);
			MarshalDirectiveException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr, 100672993);
			MarshalDirectiveException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr, 100672994);
			MarshalDirectiveException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr, 100672995);
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00133674 File Offset: 0x00131874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357498, XrefRangeEnd = 357503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalDirectiveException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalDirectiveException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x001336B0 File Offset: 0x001318B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357503, XrefRangeEnd = 357505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalDirectiveException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalDirectiveException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x001336FC File Offset: 0x001318FC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalDirectiveException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalDirectiveException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalDirectiveException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00019BD9 File Offset: 0x00017DD9
		public MarshalDirectiveException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
