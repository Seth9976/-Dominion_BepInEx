using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	public class DriveNotFoundException : IOException
	{
		// Token: 0x06002075 RID: 8309 RVA: 0x000B45E8 File Offset: 0x000B27E8
		// Note: this type is marked as 'beforefieldinit'.
		static DriveNotFoundException()
		{
			Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DriveNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100668699);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100668700);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100668701);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000B4654 File Offset: 0x000B2854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320492, XrefRangeEnd = 320497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000B4690 File Offset: 0x000B2890
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 320488, RefRangeEnd = 320492, XrefRangeStart = 320488, XrefRangeEnd = 320492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000B46DC File Offset: 0x000B28DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0000AF86 File Offset: 0x00009186
		public DriveNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
