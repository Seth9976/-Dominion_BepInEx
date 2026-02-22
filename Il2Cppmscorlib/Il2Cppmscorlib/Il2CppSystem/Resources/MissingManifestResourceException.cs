using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017F RID: 383
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		// Token: 0x06001A78 RID: 6776 RVA: 0x0009A4C0 File Offset: 0x000986C0
		// Note: this type is marked as 'beforefieldinit'.
		static MissingManifestResourceException()
		{
			Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingManifestResourceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667772);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667773);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100667774);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0009A52C File Offset: 0x0009872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315794, XrefRangeEnd = 315799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0009A568 File Offset: 0x00098768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315801, RefRangeEnd = 315802, XrefRangeStart = 315799, XrefRangeEnd = 315801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0009A5B4 File Offset: 0x000987B4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00009035 File Offset: 0x00007235
		public MissingManifestResourceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
