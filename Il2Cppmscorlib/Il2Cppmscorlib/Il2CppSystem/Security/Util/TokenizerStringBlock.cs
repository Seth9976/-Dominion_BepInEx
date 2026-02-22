using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002CA RID: 714
	public sealed class TokenizerStringBlock : Object
	{
		// Token: 0x06002F89 RID: 12169 RVA: 0x000EED0C File Offset: 0x000ECF0C
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStringBlock()
		{
			Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStringBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr);
			TokenizerStringBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_block");
			TokenizerStringBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_next");
			TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, 100670817);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000EED78 File Offset: 0x000ECF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338071, RefRangeEnd = 338073, XrefRangeStart = 338067, XrefRangeEnd = 338071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStringBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00010AD2 File Offset: 0x0000ECD2
		public TokenizerStringBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000EEDB4 File Offset: 0x000ECFB4
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00010ADB File Offset: 0x0000ECDB
		public unsafe Il2CppStringArray m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000EEDE4 File Offset: 0x000ECFE4
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x00010AFA File Offset: 0x0000ECFA
		public unsafe TokenizerStringBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
