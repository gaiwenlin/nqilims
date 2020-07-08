module.exports = {
    title: 'NQI_LIMS',
    description: 'Hello, 欢迎使用前后端分离之 ASP.NET Core 后端全家桶框架!',
    base : '/.doc/',
    head: [
        ['link', {
            rel: 'icon',
            href: `/favicon.ico`
        }]
    ],
    dest: './contents/.vuepress/dist',
    ga: '',
    evergreen: true,
    themeConfig: {
        nav: [
            { text: '首页', link: '/' },
            { text: '指南', link: '/guide/' },
            { text: '更新日志', link: '/Update/' },
            { text: '参与贡献', link: '/Contribution/' },
            { text: '社区', link: '/QQ/' },
            { text: '接口API', link: 'http://apk.neters.club' },
            { text: '管理后台', link: 'http://vueadmin.neters.club' },
            { text: 'Github', link: 'https://github.com/anjoy8/NQI_LIMS' },
        ],
        sidebarDepth: 2,
        sidebar: {
          '/guide/': getGuideSidebar('Guide'),
        }
    }
}

function getGuideSidebar (groupA) {
    return [
      {
        title: groupA,
        collapsable: false,
        children: [
          '',
          'getting-started',
          'function-sheet',
          'cheat-sheet'
        ]
      }
    ]
  }