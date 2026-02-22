using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200013A RID: 314
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x0005F304 File Offset: 0x0005D504
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkInformationException()
		{
			Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "NetworkInformationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr);
			NetworkInformationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr, 100666228);
			NetworkInformationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr, 100666229);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0005F35C File Offset: 0x0005D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57465, XrefRangeEnd = 57473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkInformationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkInformationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0005F398 File Offset: 0x0005D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57473, XrefRangeEnd = 57477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkInformationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkInformationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0000A7A5 File Offset: 0x000089A5
		public NetworkInformationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
