using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x00045728 File Offset: 0x00043928
		// Note: this type is marked as 'beforefieldinit'.
		static UnityException()
		{
			Il2CppClassPointerStore<UnityException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnityException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityException>.NativeClassPtr);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100664465);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100664466);
			UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100664467);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00045794 File Offset: 0x00043994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72570, XrefRangeEnd = 72576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000457D0 File Offset: 0x000439D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72580, RefRangeEnd = 72581, XrefRangeStart = 72576, XrefRangeEnd = 72580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0004581C File Offset: 0x00043A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72581, XrefRangeEnd = 72585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0000A54D File Offset: 0x0000874D
		public UnityException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000CDA RID: 3290
		public const int Result = -2147467261;
	}
}
