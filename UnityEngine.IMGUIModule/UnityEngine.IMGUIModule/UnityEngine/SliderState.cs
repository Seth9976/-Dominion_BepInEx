using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public class SliderState : Object
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00013A20 File Offset: 0x00011C20
		// Note: this type is marked as 'beforefieldinit'.
		static SliderState()
		{
			Il2CppClassPointerStore<SliderState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "SliderState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderState>.NativeClassPtr);
			SliderState.NativeFieldInfoPtr_dragStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "dragStartPos");
			SliderState.NativeFieldInfoPtr_dragStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "dragStartValue");
			SliderState.NativeFieldInfoPtr_isDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "isDragging");
			SliderState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderState>.NativeClassPtr, 100663706);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00013AA0 File Offset: 0x00011CA0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000440B File Offset: 0x0000260B
		public SliderState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00013ADC File Offset: 0x00011CDC
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00004414 File Offset: 0x00002614
		public unsafe float dragStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartPos)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00013B04 File Offset: 0x00011D04
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000442F File Offset: 0x0000262F
		public unsafe float dragStartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartValue)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00013B2C File Offset: 0x00011D2C
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0000444A File Offset: 0x0000264A
		public unsafe bool isDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_isDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_isDragging)) = value;
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_dragStartPos;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_dragStartValue;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_isDragging;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
