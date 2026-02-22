using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public class ScrollViewState : Object
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x000136D0 File Offset: 0x000118D0
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollViewState()
		{
			Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ScrollViewState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr);
			ScrollViewState.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "position");
			ScrollViewState.NativeFieldInfoPtr_visibleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "visibleRect");
			ScrollViewState.NativeFieldInfoPtr_viewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "viewRect");
			ScrollViewState.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "scrollPosition");
			ScrollViewState.NativeFieldInfoPtr_apply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "apply");
			ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "isDuringTouchScroll");
			ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "touchScrollStartMousePosition");
			ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "touchScrollStartPosition");
			ScrollViewState.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "velocity");
			ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "previousTimeSinceStartup");
			ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, 100663705);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000137DC File Offset: 0x000119DC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollViewState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000042D7 File Offset: 0x000024D7
		public ScrollViewState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00013818 File Offset: 0x00011A18
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x000042E0 File Offset: 0x000024E0
		public unsafe Rect position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00013840 File Offset: 0x00011A40
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000042FB File Offset: 0x000024FB
		public unsafe Rect visibleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_visibleRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_visibleRect)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00013868 File Offset: 0x00011A68
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00004316 File Offset: 0x00002516
		public unsafe Rect viewRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_viewRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_viewRect)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00013890 File Offset: 0x00011A90
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00004331 File Offset: 0x00002531
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000138B8 File Offset: 0x00011AB8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0000434C File Offset: 0x0000254C
		public unsafe bool apply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_apply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_apply)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000138E0 File Offset: 0x00011AE0
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00004367 File Offset: 0x00002567
		public unsafe bool isDuringTouchScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00013908 File Offset: 0x00011B08
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00004382 File Offset: 0x00002582
		public unsafe Vector2 touchScrollStartMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00013930 File Offset: 0x00011B30
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0000439D File Offset: 0x0000259D
		public unsafe Vector2 touchScrollStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00013958 File Offset: 0x00011B58
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000043B8 File Offset: 0x000025B8
		public unsafe Vector2 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00013980 File Offset: 0x00011B80
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x000043D3 File Offset: 0x000025D3
		public unsafe float previousTimeSinceStartup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup)) = value;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000043EE File Offset: 0x000025EE
		public void ScrollTo(Rect pos)
		{
			this.ScrollTowards(pos, float.PositiveInfinity);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000139A8 File Offset: 0x00011BA8
		public bool ScrollTowards(Rect pos, float maxDelta)
		{
			Vector2 vector = this.ScrollNeeded(pos);
			bool flag = vector.sqrMagnitude < 0.0001f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = maxDelta == 0f;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = vector.magnitude > maxDelta;
					if (flag4)
					{
						vector = vector.normalized * maxDelta;
					}
					this.scrollPosition += vector;
					this.apply = true;
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000043FE File Offset: 0x000025FE
		public Vector2 ScrollNeeded(Rect pos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_visibleRect;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_viewRect;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_apply;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_isDuringTouchScroll;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_touchScrollStartMousePosition;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_touchScrollStartPosition;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_previousTimeSinceStartup;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
