using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class RankException : SystemException
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00063F8C File Offset: 0x0006218C
		// Note: this type is marked as 'beforefieldinit'.
		static RankException()
		{
			Il2CppClassPointerStore<RankException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RankException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankException>.NativeClassPtr);
			RankException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665734);
			RankException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665735);
			RankException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665736);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00063FF8 File Offset: 0x000621F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290449, XrefRangeEnd = 290454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00064034 File Offset: 0x00062234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290454, XrefRangeEnd = 290456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00064080 File Offset: 0x00062280
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00005C4D File Offset: 0x00003E4D
		public RankException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
