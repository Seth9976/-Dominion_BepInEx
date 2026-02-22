using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000042 RID: 66
	public static class VisualElementExtensions : Object
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x000043DB File Offset: 0x000025DB
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementExtensions()
		{
			Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr);
			VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementExtensions>.NativeClassPtr, 100663658);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001AD38 File Offset: 0x00018F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93436, RefRangeEnd = 93438, XrefRangeStart = 93430, XrefRangeEnd = 93436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 WorldToLocal(this VisualElement ele, Vector2 p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementExtensions.NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00004414 File Offset: 0x00002614
		public VisualElementExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000441D File Offset: 0x0000261D
		public static void StretchToParentSize(VisualElement elem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000442A File Offset: 0x0000262A
		public static void StretchToParentWidth(VisualElement elem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001AD88 File Offset: 0x00018F88
		public static void AddManipulator(VisualElement ele, IManipulator manipulator)
		{
			bool flag = manipulator != null;
			if (flag)
			{
				manipulator.target = ele;
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		public static void RemoveManipulator(VisualElement ele, IManipulator manipulator)
		{
			bool flag = manipulator != null;
			if (flag)
			{
				manipulator.target = null;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		public static Vector2 LocalToWorld(VisualElement ele, Vector2 p)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.MultiplyMatrix44Point2(ele.worldTransformRef, p);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001ADFC File Offset: 0x00018FFC
		public static Rect WorldToLocal(VisualElement ele, Rect r)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.MultiplyMatrix44Rect2(ele.worldTransformInverse, r);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001AE30 File Offset: 0x00019030
		public static Rect LocalToWorld(VisualElement ele, Rect r)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.MultiplyMatrix44Rect2(ele.worldTransformRef, r);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001AE64 File Offset: 0x00019064
		public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point)
		{
			return dest.WorldToLocal(VisualElementExtensions.LocalToWorld(src, point));
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001AE84 File Offset: 0x00019084
		public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect)
		{
			return VisualElementExtensions.WorldToLocal(dest, VisualElementExtensions.LocalToWorld(src, rect));
		}

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_VisualElement_Vector2_0;
	}
}
