using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class Internal_SubsystemDescriptors : Object
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002235 File Offset: 0x00000435
		// Note: this type is marked as 'beforefieldinit'.
		static Internal_SubsystemDescriptors()
		{
			Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "Internal_SubsystemDescriptors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr);
			Internal_SubsystemDescriptors.NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CDC File Offset: 0x00000EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131465, XrefRangeEnd = 131476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_AddDescriptor(SubsystemDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Internal_SubsystemDescriptors.NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000226E File Offset: 0x0000046E
		public Internal_SubsystemDescriptors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0;
	}
}
