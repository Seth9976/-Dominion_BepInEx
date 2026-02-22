using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x020000E7 RID: 231
	public class SpriteAtlas : Object
	{
		// Token: 0x06001441 RID: 5185 RVA: 0x0004E374 File Offset: 0x0004C574
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlas()
		{
			Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
			SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100664757);
			SpriteAtlas.get_isVariantDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_isVariantDelegate>("UnityEngine.U2D.SpriteAtlas::get_isVariant");
			SpriteAtlas.get_tagDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_tagDelegate>("UnityEngine.U2D.SpriteAtlas::get_tag");
			SpriteAtlas.get_spriteCountDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_spriteCountDelegate>("UnityEngine.U2D.SpriteAtlas::get_spriteCount");
			SpriteAtlas.GetSpriteDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpriteDelegate>("UnityEngine.U2D.SpriteAtlas::GetSprite");
			SpriteAtlas.GetSpritesScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesScripting");
			SpriteAtlas.GetSpritesWithNameScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesWithNameScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting");
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0004E414 File Offset: 0x0004C614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79554, RefRangeEnd = 79555, XrefRangeStart = 79552, XrefRangeEnd = 79554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBindTo(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0000BA9E File Offset: 0x00009C9E
		public SpriteAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0000BAA7 File Offset: 0x00009CA7
		public bool isVariant
		{
			get
			{
				return SpriteAtlas.get_isVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0004E464 File Offset: 0x0004C664
		public string tag
		{
			get
			{
				IntPtr intPtr = SpriteAtlas.get_tagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0000BAB9 File Offset: 0x00009CB9
		public int spriteCount
		{
			get
			{
				return SpriteAtlas.get_spriteCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0004E488 File Offset: 0x0004C688
		public Sprite GetSprite(string name)
		{
			IntPtr intPtr = SpriteAtlas.GetSpriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites)
		{
			return this.GetSpritesScripting(sprites);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0004E4D8 File Offset: 0x0004C6D8
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return this.GetSpritesWithNameScripting(sprites, name);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0000BACB File Offset: 0x00009CCB
		public int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
		{
			return SpriteAtlas.GetSpritesScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites));
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0000BAE3 File Offset: 0x00009CE3
		public int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return SpriteAtlas.GetSpritesWithNameScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly SpriteAtlas.get_isVariantDelegate get_isVariantDelegateField;

		// Token: 0x04000F22 RID: 3874
		private static readonly SpriteAtlas.get_tagDelegate get_tagDelegateField;

		// Token: 0x04000F23 RID: 3875
		private static readonly SpriteAtlas.get_spriteCountDelegate get_spriteCountDelegateField;

		// Token: 0x04000F24 RID: 3876
		private static readonly SpriteAtlas.GetSpriteDelegate GetSpriteDelegateField;

		// Token: 0x04000F25 RID: 3877
		private static readonly SpriteAtlas.GetSpritesScriptingDelegate GetSpritesScriptingDelegateField;

		// Token: 0x04000F26 RID: 3878
		private static readonly SpriteAtlas.GetSpritesWithNameScriptingDelegate GetSpritesWithNameScriptingDelegateField;

		// Token: 0x02000880 RID: 2176
		// (Invoke) Token: 0x06002EB3 RID: 11955
		private delegate bool get_isVariantDelegate(IntPtr @this);

		// Token: 0x02000881 RID: 2177
		// (Invoke) Token: 0x06002EB5 RID: 11957
		private delegate IntPtr get_tagDelegate(IntPtr @this);

		// Token: 0x02000882 RID: 2178
		// (Invoke) Token: 0x06002EB7 RID: 11959
		private delegate int get_spriteCountDelegate(IntPtr @this);

		// Token: 0x02000883 RID: 2179
		// (Invoke) Token: 0x06002EB9 RID: 11961
		private delegate IntPtr GetSpriteDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000884 RID: 2180
		// (Invoke) Token: 0x06002EBB RID: 11963
		private delegate int GetSpritesScriptingDelegate(IntPtr @this, IntPtr sprites);

		// Token: 0x02000885 RID: 2181
		// (Invoke) Token: 0x06002EBD RID: 11965
		private delegate int GetSpritesWithNameScriptingDelegate(IntPtr @this, IntPtr sprites, IntPtr name);
	}
}
