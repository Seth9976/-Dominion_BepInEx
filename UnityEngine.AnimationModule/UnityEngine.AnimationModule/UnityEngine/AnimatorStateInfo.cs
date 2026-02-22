using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct AnimatorStateInfo
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00006B28 File Offset: 0x00004D28
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorStateInfo()
		{
			Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorStateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr);
			AnimatorStateInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Name");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Path");
			AnimatorStateInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_FullPath");
			AnimatorStateInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Length");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Speed");
			AnimatorStateInfo.NativeFieldInfoPtr_m_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_SpeedMultiplier");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Tag");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Loop");
			AnimatorStateInfo.NativeMethodInfoPtr_IsTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006C20 File Offset: 0x00004E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89906, RefRangeEnd = 89908, XrefRangeStart = 89904, XrefRangeEnd = 89906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorStateInfo.NativeMethodInfoPtr_IsTag_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000260C File Offset: 0x0000080C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006C64 File Offset: 0x00004E64
		public bool IsName(string name)
		{
			int num = Animator.StringToHash(name);
			return num == this.m_FullPath || num == this.m_Name || num == this.m_Path;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006C9C File Offset: 0x00004E9C
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public int nameHash
		{
			get
			{
				return this.m_Path;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006CCC File Offset: 0x00004ECC
		public int shortNameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006CFC File Offset: 0x00004EFC
		public float length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006D14 File Offset: 0x00004F14
		public float speed
		{
			get
			{
				return this.m_Speed;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006D2C File Offset: 0x00004F2C
		public float speedMultiplier
		{
			get
			{
				return this.m_SpeedMultiplier;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006D44 File Offset: 0x00004F44
		public int tagHash
		{
			get
			{
				return this.m_Tag;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006D5C File Offset: 0x00004F5C
		public bool loop
		{
			get
			{
				return this.m_Loop != 0;
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_m_Speed;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_m_SpeedMultiplier;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_m_Tag;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_IsTag_Public_Boolean_String_0;

		// Token: 0x04000066 RID: 102
		[FieldOffset(0)]
		public int m_Name;

		// Token: 0x04000067 RID: 103
		[FieldOffset(4)]
		public int m_Path;

		// Token: 0x04000068 RID: 104
		[FieldOffset(8)]
		public int m_FullPath;

		// Token: 0x04000069 RID: 105
		[FieldOffset(12)]
		public float m_NormalizedTime;

		// Token: 0x0400006A RID: 106
		[FieldOffset(16)]
		public float m_Length;

		// Token: 0x0400006B RID: 107
		[FieldOffset(20)]
		public float m_Speed;

		// Token: 0x0400006C RID: 108
		[FieldOffset(24)]
		public float m_SpeedMultiplier;

		// Token: 0x0400006D RID: 109
		[FieldOffset(28)]
		public int m_Tag;

		// Token: 0x0400006E RID: 110
		[FieldOffset(32)]
		public int m_Loop;
	}
}
