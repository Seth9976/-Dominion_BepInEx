using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	public static class Random : Object
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664274);
			Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664275);
			Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664276);
			Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664277);
			Random.NativeMethodInfoPtr_get_rotationUniform_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664278);
			Random.NativeMethodInfoPtr_get_rotationUniform_Injected_Private_Static_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664279);
			Random.InitStateDelegateField = IL2CPP.ResolveICall<Random.InitStateDelegate>("UnityEngine.Random::InitState");
			Random.GetRandomUnitCircleDelegateField = IL2CPP.ResolveICall<Random.GetRandomUnitCircleDelegate>("UnityEngine.Random::GetRandomUnitCircle");
			Random.get_seedDelegateField = IL2CPP.ResolveICall<Random.get_seedDelegate>("UnityEngine.Random::get_seed");
			Random.set_seedDelegateField = IL2CPP.ResolveICall<Random.set_seedDelegate>("UnityEngine.Random::set_seed");
			Random.get_insideUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_insideUnitSphere_InjectedDelegate>("UnityEngine.Random::get_insideUnitSphere_Injected");
			Random.get_onUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_onUnitSphere_InjectedDelegate>("UnityEngine.Random::get_onUnitSphere_Injected");
			Random.get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotation_InjectedDelegate>("UnityEngine.Random::get_rotation_Injected");
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00040000 File Offset: 0x0003E200
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 67918, RefRangeEnd = 67968, XrefRangeStart = 67916, XrefRangeEnd = 67918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Range(float minInclusive, float maxInclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004004C File Offset: 0x0003E24C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 67970, RefRangeEnd = 68004, XrefRangeStart = 67968, XrefRangeEnd = 67970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Range(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00040098 File Offset: 0x0003E298
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 67970, RefRangeEnd = 68004, XrefRangeStart = 67970, XrefRangeEnd = 68004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000400E4 File Offset: 0x0003E2E4
		public unsafe static float value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 68006, RefRangeEnd = 68007, XrefRangeStart = 68004, XrefRangeEnd = 68006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00040114 File Offset: 0x0003E314
		public unsafe static Quaternion rotationUniform
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 68009, RefRangeEnd = 68016, XrefRangeStart = 68007, XrefRangeEnd = 68009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_rotationUniform_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00040144 File Offset: 0x0003E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68016, XrefRangeEnd = 68018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_rotationUniform_Injected(out Quaternion ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_rotationUniform_Injected_Private_Static_Void_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00009B46 File Offset: 0x00007D46
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00009B4F File Offset: 0x00007D4F
		public static void InitState(int seed)
		{
			Random.InitStateDelegateField(seed);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00040178 File Offset: 0x0003E378
		public static Vector3 insideUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.get_insideUnitSphere_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00009B5C File Offset: 0x00007D5C
		public static void GetRandomUnitCircle(out Vector2 output)
		{
			Random.GetRandomUnitCircleDelegateField(out output);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00040190 File Offset: 0x0003E390
		public static Vector2 insideUnitCircle
		{
			get
			{
				Vector2 vector;
				Random.GetRandomUnitCircle(out vector);
				return vector;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000401AC File Offset: 0x0003E3AC
		public static Vector3 onUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.get_onUnitSphere_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000401C4 File Offset: 0x0003E3C4
		public static Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				Random.get_rotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00009B69 File Offset: 0x00007D69
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00009B75 File Offset: 0x00007D75
		public static int seed
		{
			get
			{
				return Random.get_seedDelegateField();
			}
			set
			{
				Random.set_seedDelegateField(value);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000401DC File Offset: 0x0003E3DC
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000401F8 File Offset: 0x0003E3F8
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00040214 File Offset: 0x0003E414
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00040254 File Offset: 0x0003E454
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004028C File Offset: 0x0003E48C
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000402BC File Offset: 0x0003E4BC
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000402E8 File Offset: 0x0003E4E8
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float num = Mathf.Lerp(hueMin, hueMax, Random.value);
			float num2 = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float num3 = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color color = Color.HSVToRGB(num, num2, num3, true);
			color.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return color;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00009B82 File Offset: 0x00007D82
		public static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			Random.get_insideUnitSphere_InjectedDelegateField(out ret);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00009B8F File Offset: 0x00007D8F
		public static void get_onUnitSphere_Injected(out Vector3 ret)
		{
			Random.get_onUnitSphere_InjectedDelegateField(out ret);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00009B9C File Offset: 0x00007D9C
		public static void get_rotation_Injected(out Quaternion ret)
		{
			Random.get_rotation_InjectedDelegateField(out ret);
		}

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationUniform_Public_Static_get_Quaternion_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationUniform_Injected_Private_Static_Void_byref_Quaternion_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly Random.InitStateDelegate InitStateDelegateField;

		// Token: 0x04000BD4 RID: 3028
		private static readonly Random.GetRandomUnitCircleDelegate GetRandomUnitCircleDelegateField;

		// Token: 0x04000BD5 RID: 3029
		private static readonly Random.get_seedDelegate get_seedDelegateField;

		// Token: 0x04000BD6 RID: 3030
		private static readonly Random.set_seedDelegate set_seedDelegateField;

		// Token: 0x04000BD7 RID: 3031
		private static readonly Random.get_insideUnitSphere_InjectedDelegate get_insideUnitSphere_InjectedDelegateField;

		// Token: 0x04000BD8 RID: 3032
		private static readonly Random.get_onUnitSphere_InjectedDelegate get_onUnitSphere_InjectedDelegateField;

		// Token: 0x04000BD9 RID: 3033
		private static readonly Random.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;

		// Token: 0x0200075B RID: 1883
		// (Invoke) Token: 0x06002C77 RID: 11383
		private delegate void InitStateDelegate(int seed);

		// Token: 0x0200075C RID: 1884
		// (Invoke) Token: 0x06002C79 RID: 11385
		private delegate void GetRandomUnitCircleDelegate([Out] IntPtr output);

		// Token: 0x0200075D RID: 1885
		// (Invoke) Token: 0x06002C7B RID: 11387
		private delegate int get_seedDelegate();

		// Token: 0x0200075E RID: 1886
		// (Invoke) Token: 0x06002C7D RID: 11389
		private delegate void set_seedDelegate(int value);

		// Token: 0x0200075F RID: 1887
		// (Invoke) Token: 0x06002C7F RID: 11391
		private delegate void get_insideUnitSphere_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000760 RID: 1888
		// (Invoke) Token: 0x06002C81 RID: 11393
		private delegate void get_onUnitSphere_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000761 RID: 1889
		// (Invoke) Token: 0x06002C83 RID: 11395
		private delegate void get_rotation_InjectedDelegate([Out] IntPtr ret);
	}
}
