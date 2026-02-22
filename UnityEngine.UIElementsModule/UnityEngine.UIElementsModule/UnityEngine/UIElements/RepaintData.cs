using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000019 RID: 25
	public class RepaintData : Object
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00010794 File Offset: 0x0000E994
		// Note: this type is marked as 'beforefieldinit'.
		static RepaintData()
		{
			Il2CppClassPointerStore<RepaintData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RepaintData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepaintData>.NativeClassPtr);
			RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<currentOffset>k__BackingField");
			RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<mousePosition>k__BackingField");
			RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<currentWorldClip>k__BackingField");
			RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<repaintEvent>k__BackingField");
			RepaintData.NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100663401);
			RepaintData.NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100663402);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001083C File Offset: 0x0000EA3C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe Matrix4x4 currentOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._currentOffset_k__BackingField = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00010878 File Offset: 0x0000EA78
		public unsafe Event repaintEvent
		{
			get
			{
				return this._repaintEvent_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002974 File Offset: 0x00000B74
		public RepaintData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000108BC File Offset: 0x0000EABC
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000297D File Offset: 0x00000B7D
		public unsafe Matrix4x4 _currentOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000108E4 File Offset: 0x0000EAE4
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002998 File Offset: 0x00000B98
		public unsafe Vector2 _mousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001090C File Offset: 0x0000EB0C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000029B3 File Offset: 0x00000BB3
		public unsafe Rect _currentWorldClip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00010934 File Offset: 0x0000EB34
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000029CE File Offset: 0x00000BCE
		public unsafe Event _repaintEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000029F6 File Offset: 0x00000BF6
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000029FE File Offset: 0x00000BFE
		public Vector2 mousePosition
		{
			get
			{
				return this._mousePosition_k__BackingField;
			}
			set
			{
				this._mousePosition_k__BackingField = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002A07 File Offset: 0x00000C07
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002A0F File Offset: 0x00000C0F
		public Rect currentWorldClip
		{
			get
			{
				return this._currentWorldClip_k__BackingField;
			}
			set
			{
				this._currentWorldClip_k__BackingField = value;
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr__currentOffset_k__BackingField;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr__mousePosition_k__BackingField;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr__currentWorldClip_k__BackingField;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr__repaintEvent_k__BackingField;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0;
	}
}
