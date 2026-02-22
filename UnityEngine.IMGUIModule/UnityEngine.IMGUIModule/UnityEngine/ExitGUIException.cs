using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public sealed class ExitGUIException : Exception
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0001195C File Offset: 0x0000FB5C
		// Note: this type is marked as 'beforefieldinit'.
		static ExitGUIException()
		{
			Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ExitGUIException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr);
			ExitGUIException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663655);
			ExitGUIException.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663656);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000119B4 File Offset: 0x0000FBB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87638, RefRangeEnd = 87639, XrefRangeStart = 87632, XrefRangeEnd = 87638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitGUIException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitGUIException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000119F0 File Offset: 0x0000FBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87639, XrefRangeEnd = 87645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitGUIException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitGUIException.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00003D86 File Offset: 0x00001F86
		public ExitGUIException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
	}
}
