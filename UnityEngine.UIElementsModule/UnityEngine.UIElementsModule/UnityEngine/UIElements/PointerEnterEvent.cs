using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009C RID: 156
	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent>
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00027B18 File Offset: 0x00025D18
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEnterEvent()
		{
			Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEnterEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr);
			PointerEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100664118);
			PointerEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100664119);
			PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100664120);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00027B84 File Offset: 0x00025D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96484, XrefRangeEnd = 96487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00027BB8 File Offset: 0x00025DB8
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00027BEC File Offset: 0x00025DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96487, XrefRangeEnd = 96490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEnterEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000057A8 File Offset: 0x000039A8
		public PointerEnterEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
