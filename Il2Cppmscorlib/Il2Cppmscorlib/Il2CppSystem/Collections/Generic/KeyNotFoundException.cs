using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004B1 RID: 1201
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		// Token: 0x060046E2 RID: 18146 RVA: 0x0014607C File Offset: 0x0014427C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyNotFoundException()
		{
			Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100673805);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100673806);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100673807);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x001460E8 File Offset: 0x001442E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364045, XrefRangeEnd = 364050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00146124 File Offset: 0x00144324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364050, XrefRangeEnd = 364052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x00146170 File Offset: 0x00144370
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0001AC71 File Offset: 0x00018E71
		public KeyNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
