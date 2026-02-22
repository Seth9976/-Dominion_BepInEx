using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public sealed class SpriteBone : ValueType
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBone()
		{
			Il2CppClassPointerStore<SpriteBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr);
			SpriteBone.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Name");
			SpriteBone.NativeFieldInfoPtr_m_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Guid");
			SpriteBone.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Position");
			SpriteBone.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Rotation");
			SpriteBone.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Length");
			SpriteBone.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_ParentId");
			SpriteBone.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Color");
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0000B94B File Offset: 0x00009B4B
		public SpriteBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0000B954 File Offset: 0x00009B54
		public SpriteBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr))
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0004DF84 File Offset: 0x0004C184
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000B966 File Offset: 0x00009B66
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0004DFAC File Offset: 0x0004C1AC
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000B985 File Offset: 0x00009B85
		public unsafe string m_Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000B9BF File Offset: 0x00009BBF
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0004E024 File Offset: 0x0004C224
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000B9DA File Offset: 0x00009BDA
		public unsafe float m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0004E04C File Offset: 0x0004C24C
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000B9F5 File Offset: 0x00009BF5
		public unsafe int m_ParentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0004E074 File Offset: 0x0004C274
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000BA10 File Offset: 0x00009C10
		public unsafe Color32 m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0004E09C File Offset: 0x0004C29C
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000BA2B File Offset: 0x00009C2B
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0004E0B4 File Offset: 0x0004C2B4
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000BA35 File Offset: 0x00009C35
		public string guid
		{
			get
			{
				return this.m_Guid;
			}
			set
			{
				this.m_Guid = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0004E0CC File Offset: 0x0004C2CC
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000BA3F File Offset: 0x00009C3F
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000BA49 File Offset: 0x00009C49
		public Quaternion rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0004E0FC File Offset: 0x0004C2FC
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000BA53 File Offset: 0x00009C53
		public float length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0004E114 File Offset: 0x0004C314
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000BA5D File Offset: 0x00009C5D
		public int parentId
		{
			get
			{
				return this.m_ParentId;
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0004E12C File Offset: 0x0004C32C
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000BA67 File Offset: 0x00009C67
		public Color32 color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_m_Guid;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentId;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;
	}
}
