using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000C RID: 12
	public class RectangularVertexClipper : Object
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00008FE0 File Offset: 0x000071E0
		// Note: this type is marked as 'beforefieldinit'.
		static RectangularVertexClipper()
		{
			Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectangularVertexClipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr);
			RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_WorldCorners");
			RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_CanvasCorners");
			RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663372);
			RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663373);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009060 File Offset: 0x00007260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108550, RefRangeEnd = 108551, XrefRangeStart = 108540, XrefRangeEnd = 108550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000090C0 File Offset: 0x000072C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108551, XrefRangeEnd = 108557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectangularVertexClipper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000232E File Offset: 0x0000052E
		public RectangularVertexClipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000090FC File Offset: 0x000072FC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002337 File Offset: 0x00000537
		public unsafe Il2CppStructArray<Vector3> m_WorldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000912C File Offset: 0x0000732C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002356 File Offset: 0x00000556
		public unsafe Il2CppStructArray<Vector3> m_CanvasCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldCorners;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasCorners;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
