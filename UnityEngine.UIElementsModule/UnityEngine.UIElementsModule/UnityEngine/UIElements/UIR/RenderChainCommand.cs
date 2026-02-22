using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DF RID: 223
	public class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x00032468 File Offset: 0x00030668
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChainCommand()
		{
			Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChainCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr);
			RenderChainCommand.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "owner");
			RenderChainCommand.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "prev");
			RenderChainCommand.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "next");
			RenderChainCommand.NativeFieldInfoPtr_closing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "closing");
			RenderChainCommand.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "type");
			RenderChainCommand.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "state");
			RenderChainCommand.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "mesh");
			RenderChainCommand.NativeFieldInfoPtr_indexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "indexOffset");
			RenderChainCommand.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "indexCount");
			RenderChainCommand.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "callback");
			RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "k_ID_MainTex");
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00007E2E File Offset: 0x0000602E
		public RenderChainCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00032574 File Offset: 0x00030774
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00007E37 File Offset: 0x00006037
		public unsafe VisualElement owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000325A4 File Offset: 0x000307A4
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00007E56 File Offset: 0x00006056
		public unsafe RenderChainCommand prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000325D4 File Offset: 0x000307D4
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00007E75 File Offset: 0x00006075
		public unsafe RenderChainCommand next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00032604 File Offset: 0x00030804
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00007E94 File Offset: 0x00006094
		public unsafe bool closing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_closing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_closing)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0003262C File Offset: 0x0003082C
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00007EAF File Offset: 0x000060AF
		public unsafe CommandType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00032654 File Offset: 0x00030854
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00007ECA File Offset: 0x000060CA
		public State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_state);
				return new State(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<State>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00032684 File Offset: 0x00030884
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00007EF8 File Offset: 0x000060F8
		public unsafe MeshHandle mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000326B4 File Offset: 0x000308B4
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00007F17 File Offset: 0x00006117
		public unsafe int indexOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexOffset)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000326DC File Offset: 0x000308DC
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00007F32 File Offset: 0x00006132
		public unsafe int indexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexCount)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00032704 File Offset: 0x00030904
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00007F4D File Offset: 0x0000614D
		public unsafe Action callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00032734 File Offset: 0x00030934
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00007F6C File Offset: 0x0000616C
		public unsafe static int k_ID_MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex, (void*)(&value));
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00007F7A File Offset: 0x0000617A
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00007F87 File Offset: 0x00006187
		public void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00007F94 File Offset: 0x00006194
		public void Blit(Texture source, RenderTexture destination, float depth, [Optional] bool flip)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00032750 File Offset: 0x00030950
		public static Vector4 RectToClipSpace(Rect rc)
		{
			Matrix4x4 deviceProjectionMatrix = Utility.GetDeviceProjectionMatrix();
			Vector3 vector = deviceProjectionMatrix.MultiplyPoint(new Vector3(rc.xMin, rc.yMin, 0f));
			Vector3 vector2 = deviceProjectionMatrix.MultiplyPoint(new Vector3(rc.xMax, rc.yMax, 0f));
			return new Vector4(Mathf.Min(vector.x, vector2.x), Mathf.Min(vector.y, vector2.y), Mathf.Max(vector.x, vector2.x), Mathf.Max(vector.y, vector2.y));
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000327F4 File Offset: 0x000309F4
		public static Rect CombineScissorRects(Rect r0, Rect r1)
		{
			Rect rect = new Rect(0f, 0f, 0f, 0f);
			rect.x = Math.Max(r0.x, r1.x);
			rect.y = Math.Max(r0.y, r1.y);
			rect.xMax = Math.Max(rect.x, Math.Min(r0.xMax, r1.xMax));
			rect.yMax = Math.Max(rect.y, Math.Min(r0.yMax, r1.yMax));
			return rect;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000328A8 File Offset: 0x00030AA8
		public static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
		{
			float num = (float)Utility.GetActiveViewport().height;
			return new RectInt(0, 0, 0, 0)
			{
				x = Mathf.RoundToInt(rect.x * pixelsPerPoint),
				y = Mathf.RoundToInt(num - rect.yMax * pixelsPerPoint),
				width = Mathf.RoundToInt(rect.width * pixelsPerPoint),
				height = Mathf.RoundToInt(rect.height * pixelsPerPoint)
			};
		}

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_closing;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_indexOffset;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_k_ID_MainTex;
	}
}
